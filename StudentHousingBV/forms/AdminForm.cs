using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.forms
{
    public partial class AdminForm : Form
    {
        private bool sidebarExpand;
        private bool usersCollapse;
        private bool tasksCollapse;
        private bool rulesCollapse;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // if sidebar is expanded, minimize
                sidebarPanel.Width -= 10;
                if (sidebarPanel.Width == sidebarPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarPanel.Width += 10;
                if (sidebarPanel.Width == sidebarPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void tasksTimer_Tick(object sender, EventArgs e)
        {
            if (tasksCollapse)
            {
                // if sidebar is expanded, minimize
                tasksPanel.Height -= 10;
                if (tasksPanel.Height == tasksPanel .MinimumSize.Height)
                {
                    tasksCollapse = false;
                    tasksTimer.Stop();
                }
            }
            else
            {
                tasksPanel.Height += 10;
                if (tasksPanel.Height == tasksPanel.MaximumSize.Height)
                {
                    tasksCollapse = true;
                    tasksTimer.Stop();
                }
            }
        }


        private void usersTimer_Tick(object sender, EventArgs e)
        {
            if (usersCollapse)
            {
                // if sidebar is expanded, minimize
                usersPanel.Height -= 10;
                if (usersPanel.Height == usersPanel.MinimumSize.Height)
                {
                    usersCollapse = false;
                    usersTimer.Stop();
                }
            }
            else
            {
                usersPanel.Height += 10;
                if (usersPanel.Height == usersPanel.MaximumSize.Height)
                {
                    usersCollapse = true;
                    usersTimer.Stop();
                }
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            usersTimer.Start();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            rulesTimer.Start();
        }

        private void rulesTimer_Tick(object sender, EventArgs e)
        {
            if (rulesCollapse)
            {
                // if sidebar is expanded, minimize
                rulesPanel.Height -= 10;
                if (rulesPanel.Height == rulesPanel.MinimumSize.Height)
                {
                    rulesCollapse = false;
                    rulesTimer.Stop();
                }
            }
            else
            {
                rulesPanel.Height += 10;
                if (rulesPanel.Height == rulesPanel.MaximumSize.Height)
                {
                    rulesCollapse = true;
                    rulesTimer.Stop();
                }
            }
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            tasksTimer.Start();
        }
    }
}
