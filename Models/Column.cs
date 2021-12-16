using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public class Column
    {
        public long Id { get; set; }
        public long BatteryId { get; set; }
        public string Status { get; set; }

        public Boolean getElevatorList(List<Elevator> filteredElevators) 
        {
            var currentElevators = new List<Elevator>();
            foreach(Elevator elevator in filteredElevators) 
            {
                if ( elevator.ColumnId == this.Id) 
                {
                    currentElevators.Add(elevator);
                }
            }

            if (currentElevators.Count > 0) 
            {
                return true;
            }
            return false;
        }
    }   
}

