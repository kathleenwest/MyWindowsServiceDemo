using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyAffirmationServiceLib
{
    /// <summary>
    /// IAffirmationService
    /// A WCF Service that allows a user to retrieve a 
    /// positive affirmation response in the form of a 
    /// string. They may also send their name for a 
    /// personalized response
    /// </summary>
    [ServiceContract]
    public interface IAffirmationService
    {
        /// <summary>
        /// AffirmMe
        /// </summary>
        /// <param name="name">name of the person (optional)</param>
        /// <returns>a positive affirmation (string)</returns>
        [OperationContract]
        string AffirmMe(string name);
    }

}
