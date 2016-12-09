using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Agendamiento.Models
{
    public class EjemploModel
    {
        public EjemploModel()
        {
            
        }

        public string InitDataAsync()
        {
            HttpClient client = new HttpClient();
            Task<string> json = client.GetStringAsync("http://weblayer.us-east-1.elasticbeanstalk.com/account/UserValidate");
            return json.Result;
        }

    }

    
}
