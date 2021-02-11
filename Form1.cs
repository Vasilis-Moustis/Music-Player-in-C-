using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_3_hopefullylast03
{
    public partial class Form1 : Form
    {
        public string temp;
        public Form1()
        {
            InitializeComponent();
            //upload the list view
            msongs s2;
            s2 = new msongs();
                string[] strAllLines = System.IO.File.ReadAllLines("ml1.txt");
                for (int i = 0; i < strAllLines.Length; i++)
                {
                    string[] temp = strAllLines[i].Split(new string[] { "  " }, StringSplitOptions.None);
                    msongs s1 = new msongs();
                    s1.songn = temp[0];
                    s1.songp = temp[1];
                    s1.songtp = Convert.ToInt32(temp[2]);
                    songs.Add(s1);
                    listView1.Items.Add(s1.songn +"   Times Played:  " + s1.songtp);
                    i++;
                }
            funct dt = new funct();
            dt.date = DateTime.Today;
            label1.Text = dt.date.ToString();
            //end of list view upload
        }
        String song, path;
        String lastplayed;
        int remit;
        List<msongs> songs = new List<msongs>();
        public void update()
        {
            //this triggers on every action(normally) related to the songs and updates the listview
            listView1.Clear();
            foreach (msongs s in songs)
            {
                listView1.Items.Add(s.songn + "   Times Played:   " + s.songtp);
            }
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e){ }
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            //gets the selected song from the listview
            string[] temp1 = listView1.FocusedItem.Text.Split(new string[] { "   " }, StringSplitOptions.None);
            string k =temp1[0];
          foreach (msongs s in songs)
            {
                 if (s.songn == k)
                 {
                    lastplayed = s.songp;
                 }
            }
        }
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this should stop the playback
           msongs.stopit();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
			//when form is closing it engages in auto save mode and gets all the info to a txt file
			if (!songs.Any())
			{

			}
			else
			{
				foreach (msongs s in songs)
				{
					TextWriter writes1 = new StreamWriter("temp.txt", true);
					writes1.WriteLine(s.songn + "  " + s.songp + "  " + s.songtp + "\n");
					writes1.Close();
				}
				File.Replace("temp.txt", "ml1.txt", "temp1.txt");
				File.Delete("temp.txt");
			}			
        }
        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (msongs s in songs)
            {
                if (s.songp == lastplayed)
                {
                    s.songtp++;
                    update();
                }
            }// reference to the play funct to play
            axWindowsMediaPlayer1.URL = lastplayed;
        }

        private void removeSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!songs.Any())
            {
                MessageBox.Show("There are no songs currently imported , import some and try again");
            }
            else
            {
                int temp3 = 0;
                foreach (msongs s in songs)
                {
                    if (s.songp == lastplayed)
                    {
                        remit = temp3;
                    }
                    temp3++;
                }
                songs.RemoveAt(remit);
                update();
            }
        }

        private void randomSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!songs.Any())
            {
                MessageBox.Show("There are no songs currently imported , import some and try again");
            }
            else
            {
                int rm = 0;
                foreach (msongs s in songs)
                {
                    rm++;
                }
                Random rando = new Random();
                int ransong = rando.Next(rm);
                lastplayed = songs.ElementAt(ransong).songp.ToString();
            }

        }

        private void refreshUpdateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To play/remove a song or operate the menu you need to double click the song or item from the menu");
        }

        private void importSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // gets a song and adds it to the list including the txt (afterwards)
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                song = openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;
            }
            TextWriter writes = new StreamWriter("ml1.txt",true);
            writes.WriteLine("\n" + song + "  " + path + "  " + 0);
            msongs s1;
            s1 = new msongs();
            s1.songn = song;
            s1.songp = path;
            s1.songtp = 0;
            songs.Add(s1);
            writes.Close();
            listView1.Items.Add(s1.songn);
        }
    }
}
