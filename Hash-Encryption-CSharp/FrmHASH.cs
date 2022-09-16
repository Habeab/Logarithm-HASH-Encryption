using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
/*
 Name: Eng. Habeab Alhamed
 Twitter: @Eng_Habeab
 GitHub: https://github.com/Habeab
 Email: Habeab@gmail.com
 Whatsapp: 0553400333
 Location: Saudi Arabia
*/
namespace Hash_Encryption_CSharp
{
    public partial class FrmHASH : Form
    {
        public FrmHASH()
        {
            InitializeComponent();
        }

        private void BtnMD5_Click(object sender, EventArgs e)
        {
            using (MD5 mD5 = MD5.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(TbxData.Text);
                byte[] hashBytes = mD5.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                TbxHASH.Text = hash;
                LblCharactersLength.Text = hash.Length.ToString();
            }
        }

        private void BtnSHA1_Click(object sender, EventArgs e)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(TbxData.Text);
                byte[] hashBytes = sha1.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                TbxHASH.Text = hash;
                LblCharactersLength.Text = hash.Length.ToString();
            }
        }

        private void BtnSHA256_Click(object sender, EventArgs e)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(TbxData.Text);
                byte[] hashBytes = sha256.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                TbxHASH.Text = hash;
                LblCharactersLength.Text = hash.Length.ToString();
            }
        }

        private void BtnSHA384_Click(object sender, EventArgs e)
        {
            using (SHA384 sha384 = SHA384.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(TbxData.Text);
                byte[] hashBytes = sha384.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                TbxHASH.Text = hash;
                LblCharactersLength.Text = hash.Length.ToString();
            }
        }

        private void BtnSHA512_Click(object sender, EventArgs e)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(TbxData.Text);
                byte[] hashBytes = sha512.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                TbxHASH.Text = hash;
                LblCharactersLength.Text = hash.Length.ToString();
            }
        }
    }
}