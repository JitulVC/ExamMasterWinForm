using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamMaster
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxUserAccount.Text = "beckschng";
            textBoxPasscode.Text = "123456";
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            textBoxUserAccount.Focus();
        }

        private void EncryptAppConfig()
        {
            string encStr = UtilClass.EncryptString("b14ca5898a4e4133bbce2ea2315a1916", "winformAPI");
            System.Diagnostics.Debug.WriteLine(encStr);
            string decStr = UtilClass.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", encStr);
            System.Diagnostics.Debug.WriteLine(decStr);
            encStr = UtilClass.EncryptString("b14ca5898a4e4133bbce2ea2315a1916", "6hbftfypP1X40VTuX7smQhlLR6l9zgb4YxwTTxIOxOAr3oND32ANq10A8dhzUlGXAx0MmQTQx9ePX4TjMxrsQG1jnt38A3Xq");
            System.Diagnostics.Debug.WriteLine(encStr);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUserAccount.Text.Trim().Length == 0 || textBoxPasscode.Text.Trim().Length == 0)
                {
                    labelMsg.Text = "Either User Account or Passcode is empty!";
                }
                else
                {
                    Task.Run(() => validateLogin()).Wait();
                    if (GlobalValues.LoginStatus == false)
                    {
                        labelMsg.Text = "Invalid User Account or Password!";
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured. Please refer log file. This application will terminate.", "ExamMaster Error");
                UtilClass.WriteLogs("LoginForm",ex.Message.ToString());
                this.Close();
            }
        }

        private async Task validateLogin()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri(GlobalValues.APIUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalValues.APIToken);
                var dict = new Dictionary<string, string>();
                dict.Add("useraccount", textBoxUserAccount.Text);
                dict.Add("passcode", textBoxPasscode.Text);
                var json = JsonSerializer.Serialize(dict);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("authenticate", data);
                var result = await response.Content.ReadAsStringAsync();
                result = "["+result+"]";
                var values = JsonSerializer.Deserialize<List<UserClass>>(result);
                if (values[0].id > 0)
                {
                    GlobalValues.LoginStatus = true;
                    GlobalValues.LoginUser = new UserClass();
                    GlobalValues.LoginUser.id = values[0].id;
                    GlobalValues.LoginUser.useraccount = values[0].useraccount;
                    GlobalValues.LoginUser.passcode = values[0].passcode;
                    GlobalValues.LoginUser.username = values[0].username;
                    GlobalValues.LoginUser.apikey = values[0].apikey;
                    GlobalValues.LoginUser.roleid = values[0].roleid;
                }
                else
                {
                    GlobalValues.LoginStatus = false;
                }
            }
            catch(Exception ex)
            {
                UtilClass.WriteLogs("Login",ex.Message.ToString());
                GlobalValues.LoginStatus = false;
            }
        }

        private void textBoxUserAccount_Enter(object sender, EventArgs e)
        {
            labelMsg.Text = "";
        }

        private void textBoxPasscode_Enter(object sender, EventArgs e)
        {
            labelMsg.Text = "";
        }
    }
}
