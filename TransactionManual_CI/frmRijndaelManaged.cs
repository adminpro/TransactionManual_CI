using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TransactionManual_CI
{
    public partial class frmRijndaelManaged : Form
    {
        RijndaelManaged aes = new RijndaelManaged();
        public frmRijndaelManaged()
        {
            InitializeComponent();
        }
        #region Encrypt
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtDecryptText.Text = EncryptASE(txtEncryptText.Text);
        }

        private void chkEncryptKey_CheckedChanged(object sender, EventArgs e)
        {
            if (txtEncryptKey.Text.Trim() == string.Empty)
                return;

            if (chkEncryptKey.Checked)
            {
                txtEncryptKey.Text = StringToBase64(txtEncryptKey.Text);
            }
            else
            {
                txtEncryptKey.Text = Base64ToString(txtEncryptKey.Text);
            }
        }

        private void chkEncryptIV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtEncryptIV.Text.Trim() == string.Empty)
                return;

            if (chkEncryptIV.Checked)
            {
                txtEncryptIV.Text = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtEncryptIV.Text));
            }
            else
            {
                txtEncryptIV.Text = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(txtEncryptIV.Text));
            }
        }
        #endregion

        #region Decrypt
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtEncryptText.Text = DecryptASE(txtDecryptText.Text);
        }

        private void chkDecryptKey_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDecryptKey.Text.Trim() == string.Empty)
                return;

            if (chkDecryptKey.Checked)
            {
                txtDecryptKey.Text = StringToBase64(txtDecryptKey.Text);
            }
            else
            {
                txtDecryptKey.Text = Base64ToString(txtDecryptKey.Text);
            }
        }

        private void chkDecryptIV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDecryptIV.Text.Trim() == string.Empty)
                return;

            if (chkDecryptIV.Checked)
            {
                txtDecryptIV.Text = StringToBase64(txtDecryptIV.Text);
            }
            else
            {
                txtDecryptIV.Text = Base64ToString(txtDecryptIV.Text);
            }
        }
        #endregion

        #region Function
        /// <summary>
        /// Encrypts the ASE.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>string</returns>
        public string EncryptASE(string text)
        {
            try
            {
                aes.BlockSize = 128;
                aes.KeySize = 256;
                aes.IV = Convert.FromBase64String(chkEncryptIV.Checked ? txtEncryptIV.Text : StringToBase64(txtEncryptIV.Text));
                aes.Key = Convert.FromBase64String(chkEncryptKey.Checked ? txtEncryptKey.Text : StringToBase64(txtEncryptKey.Text));
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                // Convert string to byte array
                byte[] src = Encoding.Unicode.GetBytes(text);

                // encryption
                using (ICryptoTransform encrypt = aes.CreateEncryptor())
                {
                    byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);

                    // Convert byte array to Base64 strings
                    return Convert.ToBase64String(dest);
                }
            }
            catch (Exception ex)
            {
                return text;
            }
        }

        /// <summary>
        /// Decrypts the ASE.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public string DecryptASE(string text)
        {
            try
            {
                aes.BlockSize = 128;
                aes.KeySize = 256;
                aes.IV = Convert.FromBase64String(chkDecryptIV.Checked ? txtDecryptIV.Text : StringToBase64(txtDecryptIV.Text));
                aes.Key = Convert.FromBase64String(chkDecryptKey.Checked ? txtDecryptKey.Text : StringToBase64(txtDecryptKey.Text));
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                // Convert Base64 strings to byte array
                byte[] src = System.Convert.FromBase64String(text);


                // decryption
                using (ICryptoTransform decrypt = aes.CreateDecryptor())
                {
                    byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                    return Encoding.Unicode.GetString(dest);
                }
            }
            catch
            {
                return text;

            }
        }

        private string StringToBase64(string str)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(str));
        }
        private string Base64ToString(string strBase64)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(strBase64));
        }
        #endregion

        private void btnKeyToClipboard_Click(object sender, EventArgs e)
        {
            aes.GenerateKey();
            Clipboard.SetText(aes.Key);
        }

        private void btnIVToClipboard_Click(object sender, EventArgs e)
        {
            aes.GenerateIV();
            Clipboard.SetText(aes.IV);
        }
    }
}
