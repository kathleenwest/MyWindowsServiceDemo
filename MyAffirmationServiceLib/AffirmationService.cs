using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyAffirmationServiceLib
{
    /// <summary>
    /// Implements the AffirmationService Interface
    /// </summary>
    public class AffirmationService : IAffirmationService
    {
        // List to hold my positive affirmations
        private List<string> myAffirmations;
        // Random number for picking which one to return
        private Random random;
        // Random number
        private int number;

        public AffirmationService()
        {
            // Initialize the in-memory lists
            Initialize();

        } // end of constructor

        /// <summary>
        /// AffirmMe
        /// Implements the Interface
        /// Returns a positive affirmation
        /// </summary>
        /// <param name="name">name of the person (string) with default "Stranger"</param>
        /// <returns>a positive affirmation (string)</returns>
        public string AffirmMe(string name)
        {
            // Make Sure Initialized
            if(myAffirmations == null)
            {
                // Load the in-memory list
                Initialize();
            }

            // Get random number
            number = random.Next(myAffirmations.Count);

            // Return the list item
            return name + ", say this: " + myAffirmations[number];

        } // end of method

        /// <summary>
        /// Initalize()
        /// Load the list of positive affirmations into memory
        /// Initialize the random number
        /// </summary>
        public void Initialize()
        {
            // Initialize the List
            myAffirmations = new List<string>()
            {
                "I am love. I am purpose. ...",
                "I don't sweat the small stuff. (@gabbybernstein) ...",
                "I can. ...",
                "I am adventurous. ...",
                "I feed my spirit. ...",
                "I am in charge of how I feel and today I am choosing happiness. ...",
                "I am my own superhero. ...",
                "I will not compare myself to strangers on the Internet",
                "Every now and then, there are days when you just need a little pick-me-up. ...",
                "I'm allowed to take up space.",
                "My past is not a reflection of my future.",
                "I am smart enough to make my own decisions.",
                "I'm in control of how I react to others.",
                "I choose peace.",
                "I'm courageous and stand up for myself.",
                "I will succeed today.",
                "I create a safe and secure space for myself wherever I am.",
                "I give myself permission to do what is right for me.",
                "I am confident in my ability to [fill in the blank].",
                "I use my time and talents to help others [fill in the blank].",
                "What I love about myself is my ability to [fill in the blank].",
                "I feel proud of myself when I [fill in the blank].",
                "I give myself space to grow and learn.",
                "I allow myself to be who I am without judgment.",
                "I listen to my intuition and trust my inner guide.",
                "I accept my emotions and let them serve their purpose.",
                "I give myself the care and attention that I deserve.",
                "My drive and ambition allow me to achieve my goals.",
                "I share my talents with the world by [fill in the blank].",
                "I am good at helping others to [fill in the blank].",
                "I am always headed in the right direction.",
                "I trust that I am on the right path.",
                "I am creatively inspired by the world around me.",
                "My mind is full of brilliant ideas.",
                "I put my energy into things that matter to me.",
                "I trust myself to make the right decision.",
                "I am becoming closer to my true self every day.",
                "I am grateful to have people in my life who [fill in the blank].",
                "I am learning valuable lessons from myself every day.",
                "I am at peace with who I am as a person.",
                "I make a difference in the world by simply existing in it."
            };

            // Set the Random number
            random = new Random();

        } // end of method

    }
}
