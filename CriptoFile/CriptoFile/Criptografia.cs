using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CriptoFile
{
    class Criptografia
    {
        //declaração de CsParameters e RsaCryptoServiceProvider

        //objetos com escopo global na classe
        public static CspParameters cspp;
        public static RSACryptoServiceProvider rsa;

        //caminhos variaveis para a fonte, pasta de criptografia e pasta de descriptografia
        private static string _encrFolder;
        public static string EncrFolder
        {
            get
            {
                return _encrFolder;
            }
            set
            {
                _encrFolder = value;
                //definir o caminho do arquivo
                PubKeyFile = _encrFolder + "rsaPublicKey.txt";
            }
        }

        public static string DecrFolder { get; set; }
        public static string SrcFolder { get; set; }

        //arquivo chave publica
        private static string PubKeyFile = EncrFolder + "rsaPublicKey.txt";

        //chave contendo o nome para private/public key value pair
        public static string keyName;

        public static string CreateAsmKeys()
        {
            string result = "";

            //armazena uma key pair na key container
            if (string.IsNullOrEmpty(keyName))
            {
                result = "Chave publica não definida";
                return result;
            }
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly)
            {
                result = "Key: " + cspp.KeyContainerName + " - Somente Publica";
            }
            else
            {
                result = "Key: " + cspp.KeyContainerName + " - Key Pair Completa";
            }

            return result;
        }

    }
}
