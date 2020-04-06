using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;
using UnityEditor;
using UnityEditor.AnimatedValues;
using System.Collections;
using System.Collections.Generic;

namespace OmiyaGames.Template.Editor.Tests
{
    ///-----------------------------------------------------------------------
    /// <copyright file="TestEditorExample.cs" company="Omiya Games">
    /// The MIT License (MIT)
    /// 
    /// Copyright (c) 2019-2020 Omiya Games
    /// 
    /// Permission is hereby granted, free of charge, to any person obtaining a copy
    /// of this software and associated documentation files (the "Software"), to deal
    /// in the Software without restriction, including without limitation the rights
    /// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    /// copies of the Software, and to permit persons to whom the Software is
    /// furnished to do so, subject to the following conditions:
    /// 
    /// The above copyright notice and this permission notice shall be included in
    /// all copies or substantial portions of the Software.
    /// 
    /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    /// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    /// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    /// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    /// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    /// THE SOFTWARE.
    /// </copyright>
    /// <author>Taro Omiya</author>
    /// <date>12/31/2019</date>
    ///-----------------------------------------------------------------------
    /// <summary>
    /// This is an example script for testing a package's editor script.
    /// </summary>
    /// 
    /// <seealso cref="EditorExample"/>
    /// 
    /// <remarks>
    /// Revision History:
    /// <list type="table">
    /// <listheader>
    ///   <description>Date</description>
    ///   <description>Author</description>
    ///   <description>Description</description>
    /// </listheader>
    /// <item>
    ///   <description>12/31/2019</description>
    ///   <description>Taro</description>
    ///   <description>Initial verison</description>
    /// </item>
    /// <item>
    ///   <description>4/5/2020</description>
    ///   <description>Taro</description>
    ///   <description>Updated with proper example.</description>
    /// </item>
    /// </list>
    /// </remarks>
    public class TestEditorExample
    {
        /// <summary>
        /// A Test behaves as an ordinary method
        /// </summary>
        [Test]
        public void TestEditorExampleSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        /// <summary>
        /// A UnityTest behaves like a coroutine in Play Mode.
        /// In Edit Mode you can use the following line to skip a frame:
        /// <code>yield return null;</code>
        /// </summary>
        [UnityTest]
        public IEnumerator TestEditorExampleWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
