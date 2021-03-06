/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Scripting.Hosting;

namespace ZyGames.Framework.Script
{
    ///<summary>
    /// Python�ļ���Ϣ
    ///</summary>
    public class PythonFileInfo : ScriptFileInfo
    {
        ///<summary>
        ///</summary>
        ///<param name="fileCode"></param>
        ///<param name="fileName"></param>
        ///<param name="compiledCode"></param>
        public PythonFileInfo(string fileCode, string fileName, CompiledCode compiledCode)
            : base(fileCode, fileName)
        {
            _compiledCode = compiledCode;
            _type = ScriptType.Python;
        }

        private CompiledCode _compiledCode;

        /// <summary>
        /// The Compiled Code.
        /// </summary>
        public CompiledCode CompiledCode
        {
            get { return _compiledCode; }
        }
    }
}