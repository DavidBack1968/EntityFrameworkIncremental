namespace EntityFrameworkList.Tests
{
    using System;


    public class ConnectionStringDefinitions// : IConnectionStringDefinitions
    {
        //private static string _timeout = ParseTimeout();
        //private static int _candidateTimeOut;

        //private static readonly string TimeoutSuffix = "Connection Timeout=" + _timeout + ";";
        //private static readonly string InternetConnStrTesting = ConfigurationManager.ConnectionStrings[ConnectionStringKeys.INTERNET_TEST].ConnectionString + TimeoutSuffix;
        //private static readonly string FTDataConnStrTesting   = ConfigurationManager.ConnectionStrings[ConnectionStringKeys.FTDATA_TEST].ConnectionString + TimeoutSuffix;

        public string GetConnectionString(ApplicationEnvironment environment, ApplicationDatabase context)
        {
            //string connectionString;
            if (environment == ApplicationEnvironment.Production)
            {
                throw new NotImplementedException();
            }

            return "UNIDATA";

            //else
            //{
            //    switch (context)
            //    {
            //        case ApplicationDatabase.FTData:
            //            throw new NotImplementedException();
            //            connectionString = FTDataConnStrTesting;
            //            break;
            //        case ApplicationDatabase.Internet:
            //            connectionString = InternetConnStrTesting;
            //            break;
            //        default:
            //            throw new NotImplementedException();
            //    }
            //}

            //return connectionString;

        }

        private static string ParseTimeout()
        {
            return "300";
            //_timeout = ConfigurationManager.AppSettings[GlobalConstants.CONFIGKEY_APPSETTINGS_DBTIMEOUT];
            //if (!int.TryParse(_timeout, NumberStyles.Integer, CultureInfo.InvariantCulture, out _candidateTimeOut))
            //    _candidateTimeOut = 300;
            //_timeout = _candidateTimeOut.ToString(CultureInfo.InvariantCulture);

            //return _timeout;
        }
    }
}