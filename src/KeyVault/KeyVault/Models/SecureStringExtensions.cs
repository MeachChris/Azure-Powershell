
//
// Copyright © Microsoft Corporation, All Rights Reserved
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS
// OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION
// ANY IMPLIED WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A
// PARTICULAR PURPOSE, MERCHANTABILITY OR NON-INFRINGEMENT.
//
// See the Apache License, Version 2.0 for the specific language
// governing permissions and limitations under the License.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Azure.Commands.KeyVault.Models
{

    /// <summary>
    /// Extends SecureString and string to convert from one to the other
    /// </summary>
    public static class SecureStringExtensions
    {

        /// <summary>
        /// Converts a string into a secure string.
        /// </summary>
        /// <param name="value">the string to be converted.</param>
        /// <returns>The secure string converted from the input string </returns>
        public static SecureString ConvertToSecureString(this string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            unsafe
            {
                fixed (char* chars = value)
                {
                    SecureString secureString = new SecureString(chars, value.Length);
                    secureString.MakeReadOnly();
                    return secureString;
                }
            }
        }

        /// <summary>
        /// Converts the secure string to a string.
        /// </summary>
        /// <param name="secureString">the secure string to be converted.</param> 
        /// <returns>The string converted from a secure string </returns>
        public static string ConvertToString(this SecureString secureString)
        {
            if (secureString == null)
            {
                throw new ArgumentNullException("secureString");
            }

            IntPtr stringPointer = IntPtr.Zero;
            try
            {
                stringPointer = Marshal.SecureStringToBSTR(secureString);
                return Marshal.PtrToStringBSTR(stringPointer);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(stringPointer);
            }
        }
    }
}
