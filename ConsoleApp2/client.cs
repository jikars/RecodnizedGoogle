using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class client : SpeakRecordGoolge.ISpeakRecordCallback
    {
    
        public client()
        {
            InstanceContext context = new InstanceContext(this);
            SpeakRecordGoolge.SpeakRecordClient speakRecordClient = new SpeakRecordGoolge.SpeakRecordClient(context);
            speakRecordClient.StartRecordAsync(2);
        }

        public void TranscriptContract(string textTranscrip)
        {
            throw new NotImplementedException();
        }
    }
}
