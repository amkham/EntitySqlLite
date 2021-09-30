using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace EntitySqlLite
{
    public partial class Form1 : Form
    {
        UserContext db;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new UserContext();
            User user = new User();
            user.Name = "work";
            db.Users.Add(user);
            db.SaveChanges();

            List<User> users = db.Users.ToList();

            foreach (var u in users)
            {

                textBox1.Text = textBox1.Text + u.Name + " " + u.Id+ Environment.NewLine;
            }
           
        }
    }
}
