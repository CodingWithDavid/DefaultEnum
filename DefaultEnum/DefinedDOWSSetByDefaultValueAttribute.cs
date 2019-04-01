/*########################################################
 *#  DefaultEnum.dll                                     #
 *#  Copyright 2018 by WesTex Enterprises                #
 *########################################################*/

using System.ComponentModel;

namespace DefaultEnum
{
    /// <summary>
    /// This enumeration is used to demonstrant how the default 
    /// attribute is igonred with call the "default" keyword 
    /// </summary>
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
}
