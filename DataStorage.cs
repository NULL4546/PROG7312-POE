using System;
using System.Collections.Generic;

namespace PROG7312Lopes
{
    public static class DataStorage
    {
        // Dictionary to map each request by a unique ID
        public static Dictionary<int, UserInput> ServiceRequests = new Dictionary<int, UserInput>();

        private static int _nextID = 1;

        public static int GenerateID()
        {
            return _nextID++;
        }

        public static void AddServiceRequest(UserInput input)
        {
            input.ID = GenerateID();
            ServiceRequests[input.ID] = input;

            if (ServiceRequestTree.ContainsKey(input.Category))
            {
                ServiceRequestTree[input.Category].Add(input);
            }
        }

        public static void UpdateServiceRequest(int id, string status, string notes)
        {
            if (ServiceRequests.ContainsKey(id))
            {
                ServiceRequests[id].Status = status;
                ServiceRequests[id].Notes = notes;
            }
        }

        public static List<UserInput> GetAllRequests()
        {
            return new List<UserInput>(ServiceRequests.Values);
        }

        public static Dictionary<string, List<UserInput>> ServiceRequestTree = new Dictionary<string, List<UserInput>>
        {
            { "Roads", new List<UserInput>() },
            { "Sanitation", new List<UserInput>() },
            { "Utilities", new List<UserInput>() }
        };
    }
}
