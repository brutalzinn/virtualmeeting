using McMaster.NETCore.Plugins;
using PluginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Remake this
namespace VirtualMeetingMonitor.Forms.WorshopForms
{
    public partial class PackageEditor : System.Windows.Forms.Form
    {
        private Package package;

        public Package Package { get => package; set => package = value; }

        public PackageEditor()
        {
            InitializeComponent();
        }

        public void OpenPackage(Package import)
        {
            package = import;

            FileTabControl.Controls.Clear();

            FileTree.Nodes.Clear();
            listBox1.Items.Clear();

            object[] files = package.GetFiles();

            if( package.IsZipped )
                files.Cast<ZipArchiveEntry>().ToList().ForEach(x => FileTree.Nodes.Add(new TreeNode(x.Name)));
            else
                files.ToList().ForEach(x => FileTree.Nodes.Add(new TreeNode(Path.GetFileName((string)x))));

                List<PluginLoader> loaders = new List<PluginLoader>();
           
                var dirName = Path.GetFileName(import.ArchivePath);
                var pluginDll = Path.Combine(import.ArchivePath, dirName + ".dll");
                if (File.Exists(pluginDll))
                {
                    var loader = PluginLoader.CreateFromAssemblyFile(
                        pluginDll,
                        sharedTypes: new[] { typeof(IPlugin) });
                    loaders.Add(loader);
                }
            
                foreach (var loader in loaders)
                {
                foreach (var pluginType in loader
                    .LoadDefaultAssembly()
                    .GetTypes()
                    .Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsAbstract))
                {
                    // This assumes the implementation of IPlugin has a parameterless constructor
                    var plugin = Activator.CreateInstance(pluginType) as IPlugin;
                  
                        foreach (var item in plugin.GetPlaceHolder())
                        {
                            listBox1.Items.Add($"TAG: [{item.Key.ToUpper()}] : {item.Value()}");
                        }

                   
                 
                    //new MethodExecutor(plugin.GetPlaceHolder(), Globals.Methods, plugin.Main);
                }

            }


            Show();
        }

        private void editorFileTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string contents = Package.ReadFileContents(e.Node.FullPath);

            foreach (Control control in FileTabControl.Controls)
            {
                if (control.Text == e.Node.FullPath)
                    return;
            }

            TabPage fileTab = new TabPage();
            fileTab.Name = "Page";
            fileTab.Text = e.Node.FullPath;
            FileTabControl.Controls.Add(fileTab);

            TextBox code = new TextBox();
            code.Name = "Code";
            code.Dock = DockStyle.Fill;
            code.BorderStyle = BorderStyle.None;
            code.Margin = new Padding(0);
            code.Multiline = true;
            code.Text = contents;
            code.AcceptsTab = true;
            
            code.ScrollBars = ScrollBars.Vertical;
            code.TextChanged += (o, ev) =>
            {
                foreach (TreeNode node in FileTree.Nodes)
                {
                    if (node.Text == FileTabControl.SelectedTab.Text)
                        node.ForeColor = System.Drawing.Color.FromArgb(0, 215, 0);
                }
            };
            fileTab.Controls.Add(code);

            FileTabControl.SelectTab(fileTab);
        }

        private void packageRun_Click(object sender, EventArgs e)
        {
           // Core.MainWindow.Invoke(new Action(() => Core.MainWindow.Activate()));

            saveAllToolStripMenuItem_Click(null, null);

         //   package.Run(true);
        }

        private void PackageEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();

            e.Cancel = true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileTabControl.SelectedTab == null)
                return;

            Package.WriteFileContents(FileTabControl.SelectedTab.Text, FileTabControl.SelectedTab.Controls.Find("Code", true).First().Text);

            foreach (TreeNode node in FileTree.Nodes)
            {
                if (node.Text == FileTabControl.SelectedTab.Text)
                    node.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control tab in FileTabControl.Controls)
            {
                Package.WriteFileContents(tab.Text, tab.Controls.Find("Code", false).First().Text);

                foreach (TreeNode node in FileTree.Nodes)
                {
                    if (node.Text == tab.Text)
                        node.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PackageEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
