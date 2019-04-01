
using System.ComponentModel;

namespace DefaultEnum
{
    public enum DaysOfTheWeekSetByZeroValue
    {
        Monday = 0,
        Tuesday = 1,
        Wendesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
    }

    [DefaultValue(Tuesday)]
    public enum DOWSetByZeroValueWithDefaultValueAttribute
    {
        Monday = 0,
        Tuesday = 1,
        Wendesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
    }

    [DefaultValue(Tuesday)]
    public enum DefinedDOWSSetByDefaultValueAttribute
    {
        Monday,
        Tuesday,
        Wendesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    public enum NextDOWSetByZeroValueWithANegitive
    {
        NoDay = -1,
        Tuesday = 1,
        Wendesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6,
        Monday = 0,
    }

    public enum ByOrderDOWS
    {
        Sunday,
        Monday,
        Tuesday,
        Wendesday,
        Thursday,
        Friday,
        Saturday
    }

    public enum MultipleZeroDOW
    {
        Monday = 0,
        NoDay = 0,
        Tuesday = 1,
        Wendesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }
}
