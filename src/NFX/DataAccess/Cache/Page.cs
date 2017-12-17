/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2017 ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFX.DataAccess.Cache
{
    /// <summary>
    /// Abstraction of an item that can be placed in hashing bucket
    /// </summary>
    public abstract class Bucketed : DisposableObject
    {

    }

    /// <summary>
    /// A composite item that stores collection of CacheRecs and can be placed into a hashing bucket
    /// </summary>
    internal sealed class Page : Bucketed
    {
        internal Page(int recPerPage)
        {
            m_Records = new CacheRec[recPerPage];
        }
        internal CacheRec[] m_Records;
    }



}
