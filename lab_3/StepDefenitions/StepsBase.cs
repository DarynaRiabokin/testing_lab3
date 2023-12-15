using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3.StepDefenitions
{
    public class StepsBase
    {
        protected RestClient client;
        protected RestRequest request;
        protected RestResponse response;
    }
}
