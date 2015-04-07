using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HOTagEditor
{
    public partial class HOTagEditorForm : Form
    {
        private HaloTagCol tagsCol;
        private patchCol patchCol;

        public HOTagEditorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tagsCol = new HaloTagCol();
            patchCol = new patchCol();
            patchCol.addPatch(new patch("34AB", "A0", globals.tagType.fx));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "tags.dat|tags.dat";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    BinaryReader reader = new BinaryReader(File.OpenRead(fileName), System.Text.Encoding.ASCII);
                    using(reader)
                    {
                        reader.BaseStream.Position = 0x4;
                        int tagListOffset = reader.ReadInt32();
                        int tagCount = reader.ReadInt32();
                        List<UInt32> offsets = new List<uint>();
                        reader.BaseStream.Position = tagListOffset;
                        for (int i = 0; i < tagCount; i++)
                        {
                            offsets.Add(reader.ReadUInt32());
                        }

                        for (int i = 0; i < tagCount; i++)
                        {
                            if(offsets[i] <= 0)
                            {
                                continue;
                            }
                            reader.BaseStream.Position = offsets[i] + 0x4;
                            int size = reader.ReadInt32();
                            string strSize = size.ToString("X");
                            string strOffset = offsets[i].ToString("X");
                            reader.BaseStream.Position = offsets[i] + 0x14;
                            string type = string.Join("", reader.ReadChars(4).Reverse());
                            switch(type)
                            {
                                case "<fx>": tagsCol.addTag(new fxTag(strOffset, strSize, "", "")); break;
                                case "achi": tagsCol.addTag(new achiTag(strOffset, strSize, "", "")); break;
                                case "adlg": tagsCol.addTag(new adlgTag(strOffset, strSize, "", "")); break;
                                case "aigl": tagsCol.addTag(new aiglTag(strOffset, strSize, "", "")); break;
                                case "ant!": tagsCol.addTag(new antTag(strOffset, strSize, "", "")); break;
                                case "arms": tagsCol.addTag(new armsTag(strOffset, strSize, "", "")); break;
                                case "beam": tagsCol.addTag(new beamTag(strOffset, strSize, "", "")); break;
                                case "bink": tagsCol.addTag(new binkTag(strOffset, strSize, "", "")); break;
                                case "bipd": tagsCol.addTag(new bipdTag(strOffset, strSize, "", "")); break;
                                case "bitm": tagsCol.addTag(new bitmTag(strOffset, strSize, "", "")); break;
                                case "bkey": tagsCol.addTag(new bkeyTag(strOffset, strSize, "", "")); break;
                                case "bloc": tagsCol.addTag(new blocTag(strOffset, strSize, "", "")); break;
                                case "bmp3": tagsCol.addTag(new bmp3Tag(strOffset, strSize, "", "")); break;
                                case "bsdt": tagsCol.addTag(new bsdtTag(strOffset, strSize, "", "")); break;
                                case "cddf": tagsCol.addTag(new cddfTag(strOffset, strSize, "", "")); break;
                                case "cfgt": tagsCol.addTag(new cfgtTag(strOffset, strSize, "", "")); break;
                                case "cfxs": tagsCol.addTag(new cfxsTag(strOffset, strSize, "", "")); break;
                                case "chad": tagsCol.addTag(new chadTag(strOffset, strSize, "", "")); break;
                                case "char": tagsCol.addTag(new char_Tag(strOffset, strSize, "", "")); break;
                                case "chdt": tagsCol.addTag(new chdtTag(strOffset, strSize, "", "")); break;
                                case "chgd": tagsCol.addTag(new chgdTag(strOffset, strSize, "", "")); break;
                                case "chmt": tagsCol.addTag(new chmtTag(strOffset, strSize, "", "")); break;
                                case "clwd": tagsCol.addTag(new clwdTag(strOffset, strSize, "", "")); break;
                                case "cmoe": tagsCol.addTag(new cmoeTag(strOffset, strSize, "", "")); break;
                                case "cntl": tagsCol.addTag(new cntlTag(strOffset, strSize, "", "")); break;
                                case "coll": tagsCol.addTag(new collTag(strOffset, strSize, "", "")); break;
                                case "colo": tagsCol.addTag(new coloTag(strOffset, strSize, "", "")); break;
                                case "cprl": tagsCol.addTag(new cprlTag(strOffset, strSize, "", "")); break;
                                case "crea": tagsCol.addTag(new creaTag(strOffset, strSize, "", "")); break;
                                case "dctr": tagsCol.addTag(new dctrTag(strOffset, strSize, "", "")); break;
                                case "decs": tagsCol.addTag(new decsTag(strOffset, strSize, "", "")); break;
                                case "draw": tagsCol.addTag(new drawTag(strOffset, strSize, "", "")); break;
                                case "drdf": tagsCol.addTag(new drdfTag(strOffset, strSize, "", "")); break;
                                case "dsrc": tagsCol.addTag(new dsrcTag(strOffset, strSize, "", "")); break;
                                case "effe": tagsCol.addTag(new effeTag(strOffset, strSize, "", "")); break;
                                case "effg": tagsCol.addTag(new effgTag(strOffset, strSize, "", "")); break;
                                case "efsc": tagsCol.addTag(new efscTag(strOffset, strSize, "", "")); break;
                                case "eqip": tagsCol.addTag(new eqipTag(strOffset, strSize, "", "")); break;
                                case "flck": tagsCol.addTag(new flckTag(strOffset, strSize, "", "")); break;
                                case "foot": tagsCol.addTag(new footTag(strOffset, strSize, "", "")); break;
                                case "form": tagsCol.addTag(new formTag(strOffset, strSize, "", "")); break;
                                case "gfxt": tagsCol.addTag(new gfxtTag(strOffset, strSize, "", "")); break;
                                case "glps": tagsCol.addTag(new glpsTag(strOffset, strSize, "", "")); break;
                                case "glvs": tagsCol.addTag(new glvsTag(strOffset, strSize, "", "")); break;
                                case "goof": tagsCol.addTag(new goofTag(strOffset, strSize, "", "")); break;
                                case "gpdt": tagsCol.addTag(new gpdtTag(strOffset, strSize, "", "")); break;
                                case "grup": tagsCol.addTag(new grupTag(strOffset, strSize, "", "")); break;
                                case "hlmt": tagsCol.addTag(new hlmtTag(strOffset, strSize, "", "")); break;
                                case "inpg": tagsCol.addTag(new inpgTag(strOffset, strSize, "", "")); break;
                                case "jmad": tagsCol.addTag(new jmadTag(strOffset, strSize, "", "")); break;
                                case "jmrq": tagsCol.addTag(new jmrqTag(strOffset, strSize, "", "")); break;
                                case "jpt!": tagsCol.addTag(new jptTag(strOffset, strSize, "", "")); break;
                                case "Lbsp": tagsCol.addTag(new LbspTag(strOffset, strSize, "", "")); break;
                                case "lens": tagsCol.addTag(new lensTag(strOffset, strSize, "", "")); break;
                                case "ligh": tagsCol.addTag(new lighTag(strOffset, strSize, "", "")); break;
                                case "lsnd": tagsCol.addTag(new lsndTag(strOffset, strSize, "", "")); break;
                                case "lst3": tagsCol.addTag(new lst3Tag(strOffset, strSize, "", "")); break;
                                case "ltvl": tagsCol.addTag(new ltvlTag(strOffset, strSize, "", "")); break;
                                case "mach": tagsCol.addTag(new machTag(strOffset, strSize, "", "")); break;
                                case "matg": tagsCol.addTag(new matgTag(strOffset, strSize, "", "")); break;
                                case "mdl3": tagsCol.addTag(new mdl3Tag(strOffset, strSize, "", "")); break;
                                case "mffn": tagsCol.addTag(new mffnTag(strOffset, strSize, "", "")); break;
                                case "mode": tagsCol.addTag(new modeTag(strOffset, strSize, "", "")); break;
                                case "mulg": tagsCol.addTag(new mulgTag(strOffset, strSize, "", "")); break;
                                case "pdm!": tagsCol.addTag(new pdmTag(strOffset, strSize, "", "")); break;
                                case "perf": tagsCol.addTag(new perfTag(strOffset, strSize, "", "")); break;
                                case "phmo": tagsCol.addTag(new phmoTag(strOffset, strSize, "", "")); break;
                                case "pixl": tagsCol.addTag(new pixlTag(strOffset, strSize, "", "")); break;
                                case "pmdf": tagsCol.addTag(new pmdfTag(strOffset, strSize, "", "")); break;
                                case "pmov": tagsCol.addTag(new pmovTag(strOffset, strSize, "", "")); break;
                                case "pphy": tagsCol.addTag(new pphyTag(strOffset, strSize, "", "")); break;
                                case "proj": tagsCol.addTag(new projTag(strOffset, strSize, "", "")); break;
                                case "prt3": tagsCol.addTag(new prt3Tag(strOffset, strSize, "", "")); break;
                                case "rasg": tagsCol.addTag(new rasgTag(strOffset, strSize, "", "")); break;
                                case "rmd": tagsCol.addTag(new rmdTag(strOffset, strSize, "", "")); break;
                                case "rmdf": tagsCol.addTag(new rmdfTag(strOffset, strSize, "", "")); break;
                                case "rmfl": tagsCol.addTag(new rmflTag(strOffset, strSize, "", "")); break;
                                case "rmhg": tagsCol.addTag(new rmhgTag(strOffset, strSize, "", "")); break;
                                case "rmop": tagsCol.addTag(new rmopTag(strOffset, strSize, "", "")); break;
                                case "rmsh": tagsCol.addTag(new rmshTag(strOffset, strSize, "", "")); break;
                                case "rmss": tagsCol.addTag(new rmssTag(strOffset, strSize, "", "")); break;
                                case "rmt2": tagsCol.addTag(new rmt2Tag(strOffset, strSize, "", "")); break;
                                case "rmtr": tagsCol.addTag(new rmtrTag(strOffset, strSize, "", "")); break;
                                case "rmw": tagsCol.addTag(new rmwTag(strOffset, strSize, "", "")); break;
                                case "rmzo": tagsCol.addTag(new rmzoTag(strOffset, strSize, "", "")); break;
                                case "rwrd": tagsCol.addTag(new rwrdTag(strOffset, strSize, "", "")); break;
                                case "sbsp": tagsCol.addTag(new sbspTag(strOffset, strSize, "", "")); break;
                                case "scen": tagsCol.addTag(new scenTag(strOffset, strSize, "", "")); break;
                                case "scn3": tagsCol.addTag(new scn3Tag(strOffset, strSize, "", "")); break;
                                case "scnr": tagsCol.addTag(new scnrTag(strOffset, strSize, "", "")); break;
                                case "sddt": tagsCol.addTag(new sddtTag(strOffset, strSize, "", "")); break;
                                case "sefc": tagsCol.addTag(new sefcTag(strOffset, strSize, "", "")); break;
                                case "sfx+": tagsCol.addTag(new sfxTag(strOffset, strSize, "", "")); break;
                                case "sgp!": tagsCol.addTag(new sgpTag(strOffset, strSize, "", "")); break;
                                case "shit": tagsCol.addTag(new shitTag(strOffset, strSize, "", "")); break;
                                case "sily": tagsCol.addTag(new silyTag(strOffset, strSize, "", "")); break;
                                case "skn3": tagsCol.addTag(new skn3Tag(strOffset, strSize, "", "")); break;
                                case "skya": tagsCol.addTag(new skyaTag(strOffset, strSize, "", "")); break;
                                case "sLdT": tagsCol.addTag(new sLdTTag(strOffset, strSize, "", "")); break;
                                case "smdt": tagsCol.addTag(new smdtTag(strOffset, strSize, "", "")); break;
                                case "sncl": tagsCol.addTag(new snclTag(strOffset, strSize, "", "")); break;
                                case "snd!": tagsCol.addTag(new sndTag(strOffset, strSize, "", "")); break;
                                case "snde": tagsCol.addTag(new sndeTag(strOffset, strSize, "", "")); break;
                                case "snmx": tagsCol.addTag(new snmxTag(strOffset, strSize, "", "")); break;
                                case "spk!": tagsCol.addTag(new spkTag(strOffset, strSize, "", "")); break;
                                case "sqtm": tagsCol.addTag(new sqtmTag(strOffset, strSize, "", "")); break;
                                case "ssce": tagsCol.addTag(new ssceTag(strOffset, strSize, "", "")); break;
                                case "styl": tagsCol.addTag(new stylTag(strOffset, strSize, "", "")); break;
                                case "sus!": tagsCol.addTag(new susTag(strOffset, strSize, "", "")); break;
                                case "trak": tagsCol.addTag(new trakTag(strOffset, strSize, "", "")); break;
                                case "trdf": tagsCol.addTag(new trdfTag(strOffset, strSize, "", "")); break;
                                case "txt3": tagsCol.addTag(new txt3Tag(strOffset, strSize, "", "")); break;
                                case "udlg": tagsCol.addTag(new udlgTag(strOffset, strSize, "", "")); break;
                                case "uise": tagsCol.addTag(new uiseTag(strOffset, strSize, "", "")); break;
                                case "unic": tagsCol.addTag(new unicTag(strOffset, strSize, "", "")); break;
                                case "vehi": tagsCol.addTag(new vehiTag(strOffset, strSize, "", "")); break;
                                case "vfsl": tagsCol.addTag(new vfslTag(strOffset, strSize, "", "")); break;
                                case "vmdx": tagsCol.addTag(new vmdxTag(strOffset, strSize, "", "")); break;
                                case "vtsh": tagsCol.addTag(new vtshTag(strOffset, strSize, "", "")); break;
                                case "wacd": tagsCol.addTag(new wacdTag(strOffset, strSize, "", "")); break;
                                case "wclr": tagsCol.addTag(new wclrTag(strOffset, strSize, "", "")); break;
                                case "weap": tagsCol.addTag(new weapTag(strOffset, strSize, "", "")); break;
                                case "wezr": tagsCol.addTag(new wezrTag(strOffset, strSize, "", "")); break;
                                case "wgan": tagsCol.addTag(new wganTag(strOffset, strSize, "", "")); break;
                                case "wgtz": tagsCol.addTag(new wgtzTag(strOffset, strSize, "", "")); break;
                                case "wigl": tagsCol.addTag(new wiglTag(strOffset, strSize, "", "")); break;
                                case "wind": tagsCol.addTag(new windTag(strOffset, strSize, "", "")); break;
                                case "wpos": tagsCol.addTag(new wposTag(strOffset, strSize, "", "")); break;
                                case "wrot": tagsCol.addTag(new wrotTag(strOffset, strSize, "", "")); break;
                                case "wscl": tagsCol.addTag(new wsclTag(strOffset, strSize, "", "")); break;
                                case "wspr": tagsCol.addTag(new wsprTag(strOffset, strSize, "", "")); break;
                                case "wtuv": tagsCol.addTag(new wtuvTag(strOffset, strSize, "", "")); break;
                            }
                        }
                        tagsCol.setContent(reader);
                    }
                    
                    string[] tagTypes = new string[] {"<fx>","achi","adlg","aigl","ant!","arms","beam","bink","bipd","bitm","bkey","bloc","bmp3","bsdt","cddf","cfgt","cfxs","chad","char","chdt","chgd","chmt","clwd","cmoe","cntl","coll","colo","cprl","crea","dctr","decs","draw","drdf","dsrc","effe","effg","efsc","eqip","flck","foot","form","gfxt","glps","glvs","goof","gpdt","grup","hlmt","inpg","jmad","jmrq","jpt!","Lbsp","lens","ligh","lsnd","lst3","ltvl","mach","matg","mdl3","mffn","mode","mulg","pdm!","perf","phmo","pixl","pmdf","pmov","pphy","proj","prt3","rasg","rmd","rmdf","rmfl","rmhg","rmop","rmsh","rmss","rmt2","rmtr","rmw","rmzo","rwrd","sbsp","scen","scn3","scnr","sddt","sefc","sfx+","sgp!","shit","sily","skn3","skya","sLdT","smdt","sncl","snd!","snde","snmx","spk!","sqtm","ssce","styl","sus!","trak","trdf","txt3","udlg","uise","unic","vehi","vfsl","vmdx","vtsh","wacd","wclr","weap","wezr","wgan","wgtz","wigl","wind","wpos","wrot","wscl","wspr","wtuv"};
                    foreach(string tagType in tagTypes)
                    {
                        List<HaloTag> tags = tagsCol.getTagsList(tagType);
                        TreeNode[] treeTags = new TreeNode[tags.Count];
                        for (int i = 0; i < tags.Count; i++)
                        {
                            treeTags[i] = new TreeNode(tags[i].getOffset());
                        }
                        TreeNode treeNode = new TreeNode(tagType, treeTags);
                        tagTreeView.Nodes.Add(treeNode);
                        
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void HOTagEditorForm_Resize(object sender, EventArgs e)
        {
            tagTreeView.Height = this.Height - 78;
            flowLayoutPanel1.Height = this.Height - 78;
            flowLayoutPanel1.Width = this.Width - tagTreeView.Width - 46;
        }

        private void tagTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 1)
            {
                string tagType = e.Node.Parent.Text;
                string offset = e.Node.Text;
                HaloTag selectedTag = tagsCol.getTag(offset, tagType);
                List<patch> availablePatches = patchCol.getPatchByType(selectedTag.getType());
                Label offsetLabel = new Label();
                offsetLabel.Text = "Offset: 0x" + selectedTag.getOffset();
                Label sizeLabel = new Label();
                sizeLabel.Text = "Size: 0x" + selectedTag.getSize();
                Label displayNameLabel = new Label();
                displayNameLabel.Text = "Display Name: " + selectedTag.getDisplayName();
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(offsetLabel);
                flowLayoutPanel1.Controls.Add(sizeLabel);
                flowLayoutPanel1.Controls.Add(displayNameLabel);
                if (availablePatches.Count == 0)
                {
                    TextBox tagContents = new TextBox();
                    tagContents.Width = flowLayoutPanel1.Width;
                    tagContents.Height = flowLayoutPanel1.Height - 46;
                    tagContents.Multiline = true;
                    tagContents.Text = BitConverter.ToString(selectedTag.getContents());
                    flowLayoutPanel1.Controls.Add(tagContents);
                }
                else
                {
                    foreach(patch patch in availablePatches)
                    {
                        Label patchLabel = new Label();
                        patchLabel.Text = "Offset: 0x" + patch.getOffset() + "Size: 0x" + patch.getSize();
                        patchLabel.Width = flowLayoutPanel1.Width;
                        flowLayoutPanel1.Controls.Add(patchLabel);
                    }
                }

            }
        }
    }
}
