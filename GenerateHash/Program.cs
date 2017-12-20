using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto.Generators;
using System.IO;
using GenerateHash.sourceText;

namespace GenerateHash
{
    class Program
    {
        static void Main(string[] args)
        {
            //web site: https://www.youtube.com/watch?v=4iPzIEXC7a8

            string SourceData;
            byte[] tmpSource;
            byte[] tmpHash;

            //enter the any text
            Console.WriteLine("Enter any text: ");

            //var _database = DataBase.meuTexto(); //database
            //var _iOS = iOS.meuTexto();
            var _ws = WebApi.meuTexto();
            SourceData = _ws;//Console.ReadLine();

            //create byte array from source data
            tmpSource = ASCIIEncoding.ASCII.GetBytes(SourceData);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Key pairs are generating ... please wait for few minutes ... ");
            Console.WriteLine();

            //RSAKeyPairGeneration
            RsaKeyPairGenerator rsaKeyPairGen = new RsaKeyPairGenerator();
            rsaKeyPairGen.Init(new KeyGenerationParameters(new SecureRandom(), 2048));
            AsymmetricCipherKeyPair keyPair = rsaKeyPairGen.GenerateKeyPair();

            //extrating the private key from the pair
            RsaKeyParameters PrivateKey = (RsaKeyParameters)keyPair.Private;
            RsaKeyParameters PublicKey = (RsaKeyParameters)keyPair.Public;

            //print the public key in pem format
            TextWriter textWriter1 = new StringWriter();
            PemWriter pemWriter1 = new PemWriter(textWriter1);
            pemWriter1.WriteObject(PublicKey);
            pemWriter1.Writer.Flush();
            string print_publicKey = textWriter1.ToString();
            Console.WriteLine("Public Key is: {0}", print_publicKey);
            Console.WriteLine();

            //generation of digital signature sha-512
            ISigner sign = SignerUtilities.GetSigner(PkcsObjectIdentifiers.Sha512WithRsaEncryption.Id);
            sign.Init(true, PrivateKey);
            sign.BlockUpdate(tmpSource, 0, tmpSource.Length);
            byte[] signature = sign.GenerateSignature();

            Console.WriteLine();
            Console.WriteLine("The digital signature is: ");
            Console.WriteLine(ByteArrayToString(signature));
            Console.WriteLine();

            //verification of the digital signature
            ISigner sign1 = SignerUtilities.GetSigner(PkcsObjectIdentifiers.Sha512WithRsaEncryption.Id);
            sign1.Init(false, PublicKey);
            sign1.BlockUpdate(tmpSource, 0, tmpSource.Length);
            bool status = sign1.VerifySignature(signature);

            Console.WriteLine();
            Console.WriteLine("Status of the digital signature: " + " ");
            if (status == true)
            {
                Console.WriteLine("Signature is valid");
                Console.WriteLine();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Signature is not valid");
                Console.WriteLine();
                Console.ReadLine();
            }
            Console.WriteLine("Please click enter two times");
            Console.ReadLine();
            
        }

        static string ByteArrayToString(byte[] arrImput)
        {
            int i;
            StringBuilder sOutPut = new StringBuilder(arrImput.Length);
            for (i = 0; i < arrImput.Length; i++)
            {
                sOutPut.Append(arrImput[i].ToString("X").ToLower());
            }
            return sOutPut.ToString();
        }
    }
}
