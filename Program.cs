using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MgSendEmail
{
    class Program
    {
        static int Main(string[] args)
        {
            SendEmail se = new SendEmail();
            if (args.Length == 7)
            {
                se.MgSendEmail(args[0], args[1], args[0], args[2], args[3], args[4], args[5], Int32.Parse(args[6]));
                return 0;
            }

            if (args.Length == 3)
            {
                se.MgSendEmail("user@domain.com.br", "password", "user@domain.com.br", args[0], args[1], args[2], "smtp.gmail.com", 25);
                return 0;
            }

            Console.WriteLine("Informe 7 ou 3 argumentos:");
            Console.WriteLine("emitente senha destinatario assunto mensagem servidor porta");
            Console.WriteLine("OU");
            Console.WriteLine("destinatarios assunto mensagem");
            
            return 1;
        }
    }
}
