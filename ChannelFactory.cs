using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net;
using ISOService_API;

namespace ISOFormat
{
    internal class ChannelFactory
    {
        internal ChannelFactory<ISOIService> factory { get; private set; }
        private ISOIService channel;

        public ISOIService Channel
        {
            get
            {
                if (factory.State != CommunicationState.Opened)
                {
                    this.channel = this.factory.CreateChannel();
                }

                return this.channel;
            }

            private set
            {
                this.channel = value;
            }
        }

        public ChannelFactory()
        {
            try
            {
#if DEBUG

                #region By nettcpBinding

                //NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
                //binding.MaxReceivedMessageSize = Int32.MaxValue;
                //binding.MaxBufferSize = Int32.MaxValue;

                //var time = new TimeSpan(10, 50, 0);
                //binding.OpenTimeout = time;
                //binding.CloseTimeout = time;
                //binding.SendTimeout = time;
                //binding.ReceiveTimeout = time;

                //EndpointAddress endpointAddress = new EndpointAddress("net.tcp://localhost:9021/");

                #endregion

                #region By HttpBinding

                BasicHttpBinding binding = new BasicHttpBinding();
                binding.MaxReceivedMessageSize = Int32.MaxValue;
                binding.MaxBufferSize = Int32.MaxValue;

                var time = new TimeSpan(10, 50, 0);
                binding.OpenTimeout = time;
                binding.CloseTimeout = time;
                binding.SendTimeout = time;
                binding.ReceiveTimeout = time;

                EndpointAddress endpointAddress = new EndpointAddress("http://localhost:9022/");

                #endregion

#endif

#if !DEBUG

                #region By HttpBinding

                BasicHttpBinding binding = new BasicHttpBinding();
                binding.MaxReceivedMessageSize = Int32.MaxValue;
                binding.MaxBufferSize = Int32.MaxValue; 

                var time = new TimeSpan(10, 50, 0);
                binding.OpenTimeout = time;
                binding.CloseTimeout = time;
                binding.SendTimeout = time;
                binding.ReceiveTimeout = time;

                //string hostingIp = "http://13.76.132.123:83/ISOService.svc/basic";

                //string hostingIp = "http://192.168.100.179:9020/ISOService.svc/basic";

                string host = ConfigurationManager.AppSettings["HostIP"];
                string hostingIp = string.Format("http://{0}/ISOService.svc/basic", host);

                EndpointAddress endpointAddress = new EndpointAddress(hostingIp);

                #endregion

#endif

                factory = new ChannelFactory<ISOIService>(binding, endpointAddress);

                this.Channel = factory.CreateChannel();
            }
            catch (TimeoutException)
            {
                if (factory != null)
                    factory.Abort();
                throw;
            }
            catch (FaultException<ServerSvcFault> ex)
            {
                throw new Exception(string.Format("Reason: {0}! Message: {1}", ex.Message, ex.Detail.FaultMessage));
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (CommunicationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
