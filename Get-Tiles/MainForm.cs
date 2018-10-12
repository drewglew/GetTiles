using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GetTiles
{
    /// <summary>
    /// Tool to generate local Tile image repository.
    /// </summary>
    /// <remarks>
    /// date created        12/10/2018
    /// author              Andrew Glew
    /// </remarks>
    public partial class MainForm : Form
    {
        private delegate void ProgressCallback(String FileRef);
        private ToolTip tt;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Contains the process of looping through all columns and rows contained within Zoom group
        /// </summary>
        private void DownloadMultipleTiles()
        {
            double Dimension = Math.Pow(2, (double)numericUpDownX.Value);

            for (int y = 0; y < Dimension; y++)
            {
                bool pathExists = System.IO.Directory.Exists(Path.Combine(textBoxLocalFolder.Text, numericUpDownX.ToString(), y.ToString()));
                if (!pathExists)
                    System.IO.Directory.CreateDirectory(Path.Combine(textBoxLocalFolder.Text, numericUpDownX.Value.ToString(), y.ToString()));

                for (int z = 0; z < Dimension; z++)
                {
                    int milliseconds = 500;
                    Thread.Sleep(milliseconds);

                    Uri baseUri = new Uri(String.Format(textBoxUrl.Text, numericUpDownX.Value.ToString(), y.ToString(), z.ToString()));

                    StringBuilder LocalFileRef = new StringBuilder();
                    LocalFileRef.Append(Path.Combine(textBoxLocalFolder.Text, numericUpDownX.Value.ToString(), y.ToString(), (z.ToString() + ".png")));

                    Console.WriteLine(baseUri.ToString());

                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(baseUri, LocalFileRef.ToString());
                        }
                        catch (Exception ex)
                        {
                            if (listBoxIssues.InvokeRequired)
                            {
                                listBoxIssues.Invoke(new ProgressCallback(SetIssueItemIntoList), new object[] { String.Format("Issue found with X {0}, Y {1}, Z {2} - ", numericUpDownX.Value.ToString(), numericUpDownY.Value.ToString(), numericUpDownZ.Value.ToString(), ex.Message) });
                            }
                            else
                            {
                                SetIssueItemIntoList(String.Format("Issue found with X {0}, Y {1}, Z {2} - ", numericUpDownX.Value.ToString(), numericUpDownY.Value.ToString(), numericUpDownZ.Value.ToString(), ex.Message));
                            }
                        }

                        if (labelStatus.InvokeRequired)
                        {
                            labelStatus.Invoke(new ProgressCallback(SetStatusLabel), new object[] { LocalFileRef.ToString() });
                        }
                        else
                        {
                            SetStatusLabel(LocalFileRef.ToString());
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Update of Status Label used within the main Zoom Level loop
        /// </summary>
        /// <param name="FileRef"></param>
        private void SetStatusLabel(String FileRef)
        {
            labelStatus.Text = String.Format("Item {0} downloaded successfully", FileRef);
        }

        /// <summary>
        /// Updates the Issue Listbox if any arise
        /// </summary>
        /// <param name="IssueText"></param>
        private void SetIssueItemIntoList(String IssueText)
        {
            listBoxIssues.Items.Add(IssueText);
            
        }
        
        /// <summary>
        /// User presses the button control to start the process.  If only Zoom checkbox is checked we loop through all columns and rows, otherwise
        /// only 1 image is generated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            labelStatus.Text = "Started";
            listBoxIssues.Items.Clear();
            
            if (checkBoxYEnabled.Checked == false && checkBoxZEnabled.Checked == false)
            {
                bool exists = System.IO.Directory.Exists( Path.Combine(textBoxLocalFolder.Text, numericUpDownX.Value.ToString()));
                if (!exists)
                    System.IO.Directory.CreateDirectory(Path.Combine(textBoxLocalFolder.Text, numericUpDownX.Value.ToString()));
                
                var work = new Thread(DownloadMultipleTiles);
                work.Start();

            } else if (checkBoxYEnabled.Checked && checkBoxZEnabled.Checked) {

                bool exists = System.IO.Directory.Exists(Path.Combine(textBoxLocalFolder.Text, numericUpDownX.Value.ToString(), numericUpDownY.Value.ToString()));
                if (!exists)
                    System.IO.Directory.CreateDirectory(Path.Combine(textBoxLocalFolder.Text, numericUpDownX.Value.ToString(), numericUpDownY.Value.ToString()));
                
                Uri baseUri = new Uri(String.Format(textBoxUrl.Text, numericUpDownX.Value.ToString(), numericUpDownY.Value.ToString(), numericUpDownZ.Value.ToString()));
                StringBuilder LocalFileRef = new StringBuilder();
                LocalFileRef.Append(Path.Combine(textBoxLocalFolder.Text, numericUpDownX.Value.ToString(), numericUpDownY.Value.ToString(), (numericUpDownZ.Value.ToString() + ".png")));

                Console.WriteLine(baseUri.ToString());

                using (WebClient client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile(baseUri, LocalFileRef.ToString());
                        labelStatus.Text = String.Format("Item {0} downloaded successfully", LocalFileRef);
                    }
                    catch (Exception ex)
                    {
                        SetIssueItemIntoList(String.Format("Issue found with X {0}, Y {1}, Z {2} - ", numericUpDownX.Value.ToString(), numericUpDownY.Value.ToString(), numericUpDownZ.Value.ToString(), ex.Message));
                    }
                }
            } else
            {
                MessageBox.Show("Select either only single Zoom checkbox to obtain collection of tile images in Zoom group or check all the checkboxes to retreive a single tile image.", "Nothing to do!");
            }
            
        }
        /// <summary>
        /// Manage the maximum limits of the Y and Z values according to the zoom level selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            long Dimension = (long)Math.Pow(2, (double)numericUpDownX.Value) - 1;  // counting zero
            if (numericUpDownY.Value > Dimension)
            {
                numericUpDownY.Value = Dimension;
            }
            if (numericUpDownZ.Value > Dimension)
            {
                numericUpDownZ.Value = Dimension;
            }
            numericUpDownY.Maximum = Dimension;
            numericUpDownZ.Maximum = Dimension;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            long Dimension = (long)Math.Pow(2, (double)numericUpDownX.Value) - 1;  // counting zero
            numericUpDownY.Maximum = Dimension;
            numericUpDownZ.Maximum = Dimension;
        }
        
        /// <summary>
        /// Tooltip on the URL textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUrl_Enter(object sender, EventArgs e)
        {
            tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.IsBalloon = true;
            tt.Show(string.Empty, textBoxUrl);
            tt.Show("Provide the Tile Providers URL here. For this to work successfully\n the values of x/y/z need to be replaced with {0}/{1}/{2}", textBoxUrl, 0);
        }

        private void textBoxUrl1_Leave(object sender, EventArgs e)
        {
            tt.Dispose();
        }


    }
}
