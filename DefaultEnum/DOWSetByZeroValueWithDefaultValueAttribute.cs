/*########################################################
 *#  DefaultEnum.dll                                     #
 *#  Copyright 2018 by WesTex Enterprises                #
 *########################################################*/

using System.ComponentModel;

namespace DefaultEnum
{
    /// <summary>
    /// This enumeration is used to demonstrant how to use the default 
    /// attribute and how it ignores the 0 index 
    /// </summary>
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
}
