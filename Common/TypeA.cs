using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // Access Modifiers : C# keywords indicate accessibility scope
    // 1.Private
    // 2.Private protected
    // 3.Protected
    // 4.Internal
    // 5.Internal protected
    // 6.Public

    // What can be written inside the Namespace 
    // 1.Class
    // 2.Struct
    // 3.Interface
    // 4.Enum

    // Access Modifiers
    // 1.Internal : Inside the same project
    // 2.Public : Everywhere

    // Default Access Modifier is internal

    // What can be written inside class and struct
    // 1. Attributes [Field - Member Variable ]
    // 2. Properties [Full,Automatic,Special(Indexer)]
    // 3. Methods - Function
    // 4. Events

    // Access Modifiers in class
    // 1.Private
    // 2.Private protected
    // 3.Protected
    // 4.Internal
    // 5.Internal protected
    // 6.Public

    // Access Modifiers in struct
    // 1.Private : inside the same class
    // 2.Internal : inside the same project
    // 3.Public : Everywhere

    // Default Access Modifier inside class or struct is private

    // What can be written inside interface
    // 1. Signature of methods [Return type - Name - Parameter]
    // 2. Signature of Property
    // 3. Default implemented method [C# 8.0 .NET Core 3.1]

    // Access Modifiers in interface
    // All except private

    // Default Access Modifier inside interface is public

    internal class TypeA
    {
        void Fun01()
        { 
          TypeA typeA = new TypeA();
          TypeB typeB = new TypeB();

            // typeB.X = 12; // invalid : private
            // typeB.Y = 12; // valid
            // typeB.Z = 12; // valid
        }
    }
}
