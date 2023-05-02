
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace TaskLib.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    [TestFixture]
    public class StructureTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {
            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("VGFza0xpYiwgVmVyc2lvbj0xLjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGw=") /*"TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.FullName == Decode("VGFza0xpYi5TdHJpbmdIZWxwZXJz") /*"TaskLib.StringHelpers"*/ );
                Assert.IsNotNull(type, "Missing assembly: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers");
                    Assert.IsTrue(type.IsClass, "assembly: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0V29yZEZyb21UZXh0") /*"GetWordFromText"*/ );                            Assert.IsNotNull(method, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.GetWordFromText(String inputInt32 wordNumberToFind) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.GetWordFromText(String inputInt32 wordNumberToFind) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.String",methodReturnType.FullName, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.GetWordFromText(String inputInt32 wordNumberToFind) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.GetWordFromText(String inputInt32 wordNumberToFind) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aW5wdXQ=") /*"input"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.GetWordFromText(String inputInt32 wordNumberToFind) parameter input does not exists or does not have type System.String");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.GetWordFromText(String inputInt32 wordNumberToFind) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("d29yZE51bWJlclRvRmluZA==") /*"wordNumberToFind"*/  && x.ParameterType.FullName == "System.Int32");
                                Assert.IsNotNull(parameter, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.GetWordFromText(String inputInt32 wordNumberToFind) parameter wordNumberToFind does not exists or does not have type System.Int32");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("UmV2ZXJzZQ==") /*"Reverse"*/ );                            Assert.IsNotNull(method, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.Reverse(String input) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.Reverse(String input) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.String",methodReturnType.FullName, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.Reverse(String input) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.Reverse(String input) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("aW5wdXQ=") /*"input"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers.Reverse(String input) parameter input does not exists or does not have type System.String");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: TaskLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:TaskLib.StringHelpers() does not exists");


        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
