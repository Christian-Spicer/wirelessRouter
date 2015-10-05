using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Wireless.Properties;
using System.Configuration;
using System.Reflection;
using Microsoft.Win32;
using System.Threading;

namespace Wireless
{
    public partial class fmrWireless : Form
    {
        public string SSID;
        public string password;
        public string mode;
        public string networktype;
        public string permission;
        public string adddelete;
        public string keyusage;
        public string ssid;

        public fmrWireless()
        {
            InitializeComponent();
            SystemEvents.PowerModeChanged += OnPowerModeChanged;
        }

        private void OnPowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            switch (e.Mode)
            {
                case PowerModes.Resume:
                    Process Sleep = new Process
                      {
                          StartInfo =
                          {
                              FileName = "netsh",
                              Arguments = "wlan Start hostednetwork",
                              UseShellExecute = false,
                              RedirectStandardOutput = true,
                              CreateNoWindow = true
                          }
                      };
                    Sleep.Start();
                    MessageBox.Show(Sleep.StandardOutput.ReadToEnd());
                    Sleep.WaitForExit();
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Process Stop = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan stop hostednetwork",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            Stop.Start();
            MessageBox.Show(Stop.StandardOutput.ReadToEnd());
            Stop.WaitForExit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Process Start = new Process
             {
                 StartInfo =
                 {
                     FileName = "netsh",
                     Arguments = "wlan start hostednetwork",
                     UseShellExecute = false,
                     RedirectStandardOutput = true,
                     CreateNoWindow = true
                 }
             };
            Start.Start();
            MessageBox.Show(Start.StandardOutput.ReadToEnd());
            Start.WaitForExit();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Process Interface = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan show interfaces",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            Interface.Start();
            MessageBox.Show(Interface.StandardOutput.ReadToEnd());
            Interface.WaitForExit();

            Process WirelessNetworks = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan show networks",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            WirelessNetworks.Start();
            MessageBox.Show(WirelessNetworks.StandardOutput.ReadToEnd());
            WirelessNetworks.WaitForExit();

            Process cmdUtility = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan show hostednetwork",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            cmdUtility.Start();
            MessageBox.Show(cmdUtility.StandardOutput.ReadToEnd());
            cmdUtility.WaitForExit();

            Process SecuritySettings = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan show hostednetwork setting=security",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            SecuritySettings.Start();
            MessageBox.Show(SecuritySettings.StandardOutput.ReadToEnd());
            SecuritySettings.WaitForExit();
            Process Profile = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan show Profile",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            Profile.Start();
            MessageBox.Show(Profile.StandardOutput.ReadToEnd());
            Profile.WaitForExit();
            Process Setting = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan show settings",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            Setting.Start();
            MessageBox.Show(Setting.StandardOutput.ReadToEnd());
            Setting.WaitForExit();

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (SSID != ttbSSID.Text)
            {
                SSID = ttbSSID.Text;
                Process NameSSID = new Process
                {
                    StartInfo =
                    {
                        FileName = "netsh",
                        Arguments = "wlan set hostednetwork ssid=" + SSID,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                NameSSID.Start();
                MessageBox.Show(NameSSID.StandardOutput.ReadToEnd());
                NameSSID.WaitForExit();
                btnStart.PerformClick();
                Settings.Default.SSIDName = SSID;
                Settings.Default.Save();
            }
            if (password != ttbPassword.Text)
            {
                password = ttbPassword.Text;
                Process Password = new Process
                {
                    StartInfo =
                    {
                        FileName = "netsh",
                        Arguments = "wlan set hostednetwork key=" + password,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                Password.Start();
                MessageBox.Show(Password.StandardOutput.ReadToEnd());
                Password.WaitForExit();
                btnStart.PerformClick();
                Settings.Default.PassWord = password;
                Settings.Default.Save();
            }
            if (mode != cbbMode.Text)
            {
                mode = cbbMode.Text;
                Process Modes = new Process
                {
                    StartInfo =
                    {
                        FileName = "netsh",
                        Arguments = "wlan set hostednetwork mode=" + mode,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                Modes.Start();
                MessageBox.Show(Modes.StandardOutput.ReadToEnd());
                Modes.WaitForExit();
                btnStart.PerformClick();
                Settings.Default.Mode = mode;
                Settings.Default.Save();
            }
            if (keyusage != cbbKeyUsage.Text)
            {
                keyusage = cbbKeyUsage.Text;
                Process KeyUsage = new Process
                {
                    StartInfo =
                    {
                        FileName = "netsh",
                        Arguments = "wlan set hostednetwork key=" + password + "keyUsage=" + keyusage,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                KeyUsage.Start();
                MessageBox.Show(KeyUsage.StandardOutput.ReadToEnd());
                KeyUsage.WaitForExit();
                btnStart.PerformClick();
                Settings.Default.Mode = mode;
                Settings.Default.Save();
            }
        }

        private void fmrWireless_Load(object sender, EventArgs e)
        {
            SSID = Settings.Default.SSIDName;
            ttbSSID.Text = SSID;
            password = Settings.Default.PassWord;
            ttbPassword.Text = password;
            mode = Settings.Default.Mode;
            cbbMode.Text = mode;
            networktype = Settings.Default.NetWorkType;
            cbbNetWorkTypes.Text = networktype;
            permission = Settings.Default.Permission;
            cbbPermission.Text = permission;
            adddelete = Settings.Default.AddDelete;
            cbbAddDelete.Text = adddelete;
            keyusage = Settings.Default.KeyUsage;
            cbbKeyUsage.Text = keyusage;

            Process WirelessNetworks = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan show networks",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            WirelessNetworks.Start();
            MessageBox.Show(WirelessNetworks.StandardOutput.ReadToEnd());
            WirelessNetworks.WaitForExit();
        }

        private void fmrWireless_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ttbSSID.Text == "")
            {
                Settings.Default.SSIDName = "Admin";
                Properties.Settings.Default.Save();
            }
            else
            {
                Settings.Default.SSIDName = SSID;
                Properties.Settings.Default.Save();
            }
            if (ttbPassword.Text == "")
            {
                Settings.Default.PassWord = "Password";
                Properties.Settings.Default.Save();
            }
            else
            {
                Settings.Default.PassWord = password;
                Properties.Settings.Default.Save();
            }
            if (cbbMode.Text == "")
            {
                Settings.Default.Mode = "Allow";
                Properties.Settings.Default.Save();
            }
            else
            {
                Settings.Default.Mode = mode;
                Properties.Settings.Default.Save();
            }
            if (cbbKeyUsage.Text == "")
            {
                Settings.Default.KeyUsage = "Persistent";
                Properties.Settings.Default.Save();
            }
            else
            {
                Settings.Default.KeyUsage = keyusage;
                Properties.Settings.Default.Save();
            }
            if (cbbNetWorkTypes.Text == "")
            {
                Settings.Default.NetWorkType = "Infrastructure";
                Properties.Settings.Default.Save();
            }
            else
            {
                Settings.Default.NetWorkType = cbbNetWorkTypes.Text;
                Properties.Settings.Default.Save();
            }
            if (cbbPermission.Text == "")
            {
                Settings.Default.Permission = "Allow";
                Properties.Settings.Default.Save();
            }
            else
            {
                Settings.Default.Permission = cbbPermission.Text;
                Properties.Settings.Default.Save();
            }
            if (cbbAddDelete.Text == "")
            {
                Settings.Default.AddDelete = "Add";
                Properties.Settings.Default.Save();
            }
            else
            {
                Settings.Default.AddDelete = cbbAddDelete.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ssid = ttbSSIDName.Text;
            adddelete = cbbAddDelete.Text;
            networktype = cbbNetWorkTypes.Text;
            permission = cbbPermission.Text;
            Process Networktype = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan " + adddelete + " filter permission=" + permission + " ssid=" + ssid + " networktype=" + networktype,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            Networktype.Start();
            MessageBox.Show(Networktype.StandardOutput.ReadToEnd());
            Networktype.WaitForExit();
            Settings.Default.NetWorkType = networktype;
            Settings.Default.Save();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (btnShowHide.Text == "Show SSID")
            {
                btnShowHide.Text = "Hide SSID";
                Process ShowBlocked = new Process
                {
                    StartInfo =
                    {
                        FileName = "netsh",
                        Arguments = "wlan set blockednetworks display=Show",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                ShowBlocked.Start();
                MessageBox.Show(ShowBlocked.StandardOutput.ReadToEnd());
                ShowBlocked.WaitForExit();
            }
            else
            {
                btnShowHide.Text = "Show SSID";
                Process ShowBlocked = new Process
                {
                    StartInfo =
                    {
                        FileName = "netsh",
                        Arguments = "wlan set blockednetworks display=hide",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };
                ShowBlocked.Start();
                MessageBox.Show(ShowBlocked.StandardOutput.ReadToEnd());
                ShowBlocked.WaitForExit();
            }
        }

        private void btnBlockedSSIDInfo_Click(object sender, EventArgs e)
        {
            Process Filter = new Process
                  {
                      StartInfo =
                      {
                          FileName = "netsh",
                          Arguments = "wlan show filters",
                          UseShellExecute = false,
                          RedirectStandardOutput = true,
                          CreateNoWindow = true
                      }
                  };
            Filter.Start();
            MessageBox.Show(Filter.StandardOutput.ReadToEnd());
            Filter.WaitForExit();
            Process WirelessNetworks = new Process
            {
                StartInfo =
                {
                    FileName = "netsh",
                    Arguments = "wlan show networks",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            WirelessNetworks.Start();
            MessageBox.Show(WirelessNetworks.StandardOutput.ReadToEnd());
            WirelessNetworks.WaitForExit();
        }

        private void fmrWireless_Resize(object sender, EventArgs e)
        {
            bool cursorNotInBar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && cursorNotInBar)//this code gets fired on every resize  
            {                                                                                      //so we check if the form was minimized  
                Hide();//hides the program on the taskbar  

                ntITaskbar.Visible = true;//shows our tray icon  
                Thread.Sleep(3000);//pause for 3 seconds  

                //shows a balloon for 1 sec with a title, some text, and the info icon  

                //other possibilities are: TooltipIcon.None, Tooltipicon.Error, and TooltipIcon.Warning  

                ntITaskbar.ShowBalloonTip(1000, "Hello", "Wireless Hotspot has been minimized", ToolTipIcon.Info);

            }
        }

        private void ntITaskbar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();//shows the program on taskbar  

            this.WindowState = FormWindowState.Normal;//undoes the minimized state of the form  

            ntITaskbar.Visible = false;//hides tray icon again  

        }

    }
}

