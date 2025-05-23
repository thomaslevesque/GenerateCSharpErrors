# All C# errors and warnings

*Parsed from the [Roslyn source code](https://github.com/dotnet/roslyn) using Roslyn.*

|Code|Severity|Message|
|----|--------|-------|
|[CS0006](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0006)|Error|Metadata file '{0}' could not be found|
|[CS0009](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0009)|Fatal|Metadata file '{0}' could not be opened -- {1}|
|[CS0012](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The type '{0}' is defined in an assembly that is not referenced. You must add a reference to assembly '{1}'.|
|[CS0016](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0016)|Error|Could not write to output file '{0}' -- '{1}'|
|[CS0017](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0017)|Error|Program has more than one entry point defined. Compile with /main to specify the type that contains the entry point.|
|[CS0019](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0019)|Error|Operator '{0}' cannot be applied to operands of type '{1}' and '{2}'|
|[CS0020](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0020)|Error|Division by constant zero|
|[CS0021](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0021)|Error|Cannot apply indexing with [] to an expression of type '{0}'|
|[CS0022](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Wrong number of indices inside []; expected {0}|
|[CS0023](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0023)|Error|Operator '{0}' cannot be applied to operand of type '{1}'|
|[CS0026](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0026)|Error|Keyword 'this' is not valid in a static property, static method, or static field initializer|
|[CS0027](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0027)|Error|Keyword 'this' is not available in the current context|
|[CS0028](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0028)|Warning|'{0}' has the wrong signature to be an entry point|
|[CS0029](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0029)|Error|Cannot implicitly convert type '{0}' to '{1}'|
|[CS0030](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0030)|Error|Cannot convert type '{0}' to '{1}'|
|[CS0031](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0031)|Error|Constant value '{0}' cannot be converted to a '{1}'|
|[CS0034](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Operator '{0}' is ambiguous on operands of type '{1}' and '{2}'|
|[CS0035](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Operator '{0}' is ambiguous on an operand of type '{1}'|
|[CS0036](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0036)|Error|An out parameter cannot have the In attribute|
|[CS0037](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0037)|Error|Cannot convert null to '{0}' because it is a non-nullable value type|
|[CS0039](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0039)|Error|Cannot convert type '{0}' to '{1}' via a reference conversion, boxing conversion, unboxing conversion, wrapping conversion, or null type conversion|
|[CS0041](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0041)|Fatal|Unexpected error writing debug information -- '{0}'|
|[CS0050](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0050)|Error|Inconsistent accessibility: return type '{1}' is less accessible than method '{0}'|
|[CS0051](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0051)|Error|Inconsistent accessibility: parameter type '{1}' is less accessible than method '{0}'|
|[CS0052](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0052)|Error|Inconsistent accessibility: field type '{1}' is less accessible than field '{0}'|
|[CS0053](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0053)|Error|Inconsistent accessibility: property type '{1}' is less accessible than property '{0}'|
|[CS0054](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0054)|Error|Inconsistent accessibility: indexer return type '{1}' is less accessible than indexer '{0}'|
|[CS0055](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0055)|Error|Inconsistent accessibility: parameter type '{1}' is less accessible than indexer or property '{0}'|
|[CS0056](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0056)|Error|Inconsistent accessibility: return type '{1}' is less accessible than operator '{0}'|
|[CS0057](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0057)|Error|Inconsistent accessibility: parameter type '{1}' is less accessible than operator '{0}'|
|[CS0058](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0058)|Error|Inconsistent accessibility: return type '{1}' is less accessible than delegate '{0}'|
|[CS0059](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0059)|Error|Inconsistent accessibility: parameter type '{1}' is less accessible than delegate '{0}'|
|[CS0060](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0060)|Error|Inconsistent accessibility: base class '{1}' is less accessible than class '{0}'|
|[CS0061](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0061)|Error|Inconsistent accessibility: base interface '{1}' is less accessible than interface '{0}'|
|[CS0065](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0065)|Error|'{0}': event property must have both add and remove accessors|
|[CS0066](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0066)|Error|'{0}': event must be of a delegate type|
|[CS0067](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0067)|Warning|The event '{0}' is never used|
|[CS0068](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0068)|Error|'{0}': instance event in interface cannot have initializer|
|[CS0070](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0070)|Error|The event '{0}' can only appear on the left hand side of += or -= (except when used from within the type '{1}')|
|[CS0071](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0071)|Error|An explicit interface implementation of an event must use event accessor syntax|
|[CS0072](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0072)|Error|'{0}': cannot override; '{1}' is not an event|
|[CS0073](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0073)|Error|An add or remove accessor must have a body|
|[CS0074](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0074)|Error|'{0}': abstract event cannot have initializer|
|[CS0075](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0075)|Error|To cast a negative value, you must enclose the value in parentheses.|
|[CS0076](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0076)|Error|The enumerator name '{0}' is reserved and cannot be used|
|[CS0077](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0077)|Error|The as operator must be used with a reference type or nullable type ('{0}' is a non-nullable value type)|
|[CS0078](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0078)|Warning|The 'l' suffix is easily confused with the digit '1' -- use 'L' for clarity|
|[CS0079](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0079)|Error|The event '{0}' can only appear on the left hand side of += or -=|
|[CS0080](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0080)|Error|Constraints are not allowed on non-generic declarations|
|[CS0081](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0081)|Error|Type parameter declaration must be an identifier not a type|
|[CS0082](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0082)|Error|Type '{1}' already reserves a member called '{0}' with the same parameter types|
|[CS0100](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0100)|Error|The parameter name '{0}' is a duplicate|
|[CS0101](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0101)|Error|The namespace '{1}' already contains a definition for '{0}'|
|[CS0102](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0102)|Error|The type '{0}' already contains a definition for '{1}'|
|[CS0103](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0103)|Error|The name '{0}' does not exist in the current context|
|[CS0104](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0104)|Error|'{0}' is an ambiguous reference between '{1}' and '{2}'|
|[CS0105](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Warning|The using directive for '{0}' appeared previously in this namespace|
|[CS0106](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0106)|Error|The modifier '{0}' is not valid for this item|
|[CS0107](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0107)|Error|More than one protection modifier|
|[CS0108](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0108)|Warning|'{0}' hides inherited member '{1}'. Use the new keyword if hiding was intended.|
|[CS0109](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0109)|Warning|The member '{0}' does not hide an accessible member. The new keyword is not required.|
|[CS0110](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0110)|Error|The evaluation of the constant value for '{0}' involves a circular definition|
|[CS0111](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Type '{1}' already defines a member called '{0}' with the same parameter types|
|[CS0112](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0112)|Error|A static member cannot be marked as '{0}'|
|[CS0113](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0113)|Error|A member '{0}' marked as override cannot be marked as new or virtual|
|[CS0114](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0114)|Warning|'{0}' hides inherited member '{1}'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.|
|[CS0115](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0115)|Error|'{0}': no suitable method found to override|
|[CS0116](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0116)|Error|A namespace cannot directly contain members such as fields, methods or statements|
|[CS0117](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0117)|Error|'{0}' does not contain a definition for '{1}'|
|[CS0118](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0118)|Error|'{0}' is a {1} but is used like a {2}|
|[CS0119](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0119)|Error|'{0}' is a {1}, which is not valid in the given context|
|[CS0120](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0120)|Error|An object reference is required for the non-static field, method, or property '{0}'|
|[CS0121](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|The call is ambiguous between the following methods or properties: '{0}' and '{1}'|
|[CS0122](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0122)|Error|'{0}' is inaccessible due to its protection level|
|[CS0123](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0123)|Error|No overload for '{0}' matches delegate '{1}'|
|[CS0126](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0126)|Error|An object of a type convertible to '{0}' is required|
|[CS0127](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0127)|Error|Since '{0}' returns void, a return keyword must not be followed by an object expression|
|[CS0128](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0128)|Error|A local variable or function named '{0}' is already defined in this scope|
|[CS0131](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0131)|Error|The left-hand side of an assignment must be a variable, property or indexer|
|[CS0132](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0132)|Error|'{0}': a static constructor must be parameterless|
|[CS0133](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0133)|Error|The expression being assigned to '{0}' must be constant|
|[CS0134](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0134)|Error|'{0}' is of type '{1}'. A const field of a reference type other than string can only be initialized with null.|
|[CS0136](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0136)|Error|A local or parameter named '{0}' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter|
|[CS0138](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|A 'using namespace' directive can only be applied to namespaces; '{0}' is a type not a namespace. Consider a 'using static' directive instead|
|[CS0139](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0139)|Error|No enclosing loop out of which to break or continue|
|[CS0140](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0140)|Error|The label '{0}' is a duplicate|
|[CS0143](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0143)|Error|The type '{0}' has no constructors defined|
|[CS0144](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0144)|Error|Cannot create an instance of the abstract type or interface '{0}'|
|[CS0145](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0145)|Error|A const field requires a value to be provided|
|[CS0146](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0146)|Error|Circular base type dependency involving '{0}' and '{1}'|
|[CS0148](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0148)|Error|The delegate '{0}' does not have a valid constructor|
|[CS0149](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0149)|Error|Method name expected|
|[CS0150](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0150)|Error|A constant value is expected|
|[CS0151](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0151)|Error|A switch expression or case label must be a bool, char, string, integral, enum, or corresponding nullable type in C# 6 and earlier.|
|[CS0152](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0152)|Error|The switch statement contains multiple cases with the label value '{0}'|
|[CS0153](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0153)|Error|A goto case is only valid inside a switch statement|
|[CS0154](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0154)|Error|The property or indexer '{0}' cannot be used in this context because it lacks the get accessor|
|[CS0155](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0155)|Error|The type caught or thrown must be derived from System.Exception|
|[CS0156](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0156)|Error|A throw statement with no arguments is not allowed outside of a catch clause|
|[CS0157](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0157)|Error|Control cannot leave the body of a finally clause|
|[CS0158](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0158)|Error|The label '{0}' shadows another label by the same name in a contained scope|
|[CS0159](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0159)|Error|No such label '{0}' within the scope of the goto statement|
|[CS0160](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0160)|Error|A previous catch clause already catches all exceptions of this or of a super type ('{0}')|
|[CS0161](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0161)|Error|'{0}': not all code paths return a value|
|[CS0162](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0162)|Warning|Unreachable code detected|
|[CS0163](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0163)|Error|Control cannot fall through from one case label ('{0}') to another|
|[CS0164](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0164)|Warning|This label has not been referenced|
|[CS0165](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0165)|Error|Use of unassigned local variable '{0}'|
|[CS0168](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0168)|Warning|The variable '{0}' is declared but never used|
|[CS0169](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0169)|Warning|The field '{0}' is never used|
|[CS0170](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0170)|Error|Use of possibly unassigned field '{0}'|
|[CS0171](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Field '{0}' must be fully assigned before control is returned to the caller. Consider updating to language version '{1}' to auto-default the field.|
|[CS0172](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0172)|Error|Type of conditional expression cannot be determined because '{0}' and '{1}' implicitly convert to one another|
|[CS0173](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0173)|Error|Type of conditional expression cannot be determined because there is no implicit conversion between '{0}' and '{1}'|
|[CS0174](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0174)|Error|A base class is required for a 'base' reference|
|[CS0175](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0175)|Error|Use of keyword 'base' is not valid in this context|
|[CS0176](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0176)|Error|Member '{0}' cannot be accessed with an instance reference; qualify it with a type name instead|
|[CS0177](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0177)|Error|The out parameter '{0}' must be assigned to before control leaves the current method|
|[CS0178](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Invalid rank specifier: expected ',' or ']'|
|[CS0179](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0179)|Error|'{0}' cannot be extern and declare a body|
|[CS0180](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0180)|Error|'{0}' cannot be both extern and abstract|
|[CS0181](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0181)|Error|Attribute constructor parameter '{0}' has type '{1}', which is not a valid attribute parameter type|
|[CS0182](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|An attribute argument must be a constant expression, typeof expression or array creation expression of an attribute parameter type|
|[CS0183](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0183)|Warning|The given expression is always of the provided ('{0}') type|
|[CS0184](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0184)|Warning|The given expression is never of the provided ('{0}') type|
|[CS0185](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lock-semantics)|Error|'{0}' is not a reference type as required by the lock statement|
|[CS0186](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0186)|Error|Use of null is not valid in this context|
|[CS0188](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|The 'this' object cannot be used before all of its fields have been assigned. Consider updating to language version '{0}' to auto-default the unassigned fields.|
|CS0190|Error|The \_\_arglist construct is valid only within a variable argument method|
|[CS0191](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0191)|Error|A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)|
|[CS0192](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|A readonly field cannot be used as a ref or out value (except in a constructor)|
|[CS0193](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0193)|Error|The \* or -\> operator must be applied to a pointer|
|[CS0196](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0196)|Error|A pointer must be indexed by only one value|
|[CS0197](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0197)|Warning|Using '{0}' as a ref or out value or taking its address may cause a runtime exception because it is a field of a marshal-by-reference class|
|[CS0198](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0198)|Error|A static readonly field cannot be assigned to (except in a static constructor or a variable initializer)|
|[CS0199](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|A static readonly field cannot be used as a ref or out value (except in a static constructor)|
|[CS0200](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0200)|Error|Property or indexer '{0}' cannot be assigned to -- it is read only|
|[CS0201](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0201)|Error|Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement|
|[CS0202](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0202)|Error|foreach requires that the return type '{0}' of '{1}' must have a suitable public 'MoveNext' method and public 'Current' property|
|[CS0204](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0204)|Error|Only 65534 locals, including those generated by the compiler, are allowed|
|[CS0205](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0205)|Error|Cannot call an abstract base member: '{0}'|
|[CS0206](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|A non ref-returning property or indexer may not be used as an out or ref value|
|[CS0208](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0208)|Error|Cannot take the address of, get the size of, or declare a pointer to a managed type ('{0}')|
|[CS0209](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0209)|Error|The type of a local declared in a fixed statement must be a pointer type|
|[CS0210](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0210)|Error|You must provide an initializer in a fixed or using statement declaration|
|[CS0211](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0211)|Error|Cannot take the address of the given expression|
|[CS0212](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0212)|Error|You can only take the address of an unfixed expression inside of a fixed statement initializer|
|[CS0213](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0213)|Error|You cannot use the fixed statement to take the address of an already fixed expression|
|[CS0214](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0214)|Error|Pointers and fixed size buffers may only be used in an unsafe context|
|[CS0215](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0215)|Error|The return type of operator True or False must be bool|
|[CS0216](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0216)|Error|The operator '{0}' requires a matching operator '{1}' to also be defined|
|[CS0217](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0217)|Error|In order to be applicable as a short circuit operator a user-defined logical operator ('{0}') must have the same return type and parameter types|
|[CS0218](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0218)|Error|In order for '{0}' to be applicable as a short circuit operator, its declaring type '{1}' must define operator true and operator false|
|[CS0219](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0219)|Warning|The variable '{0}' is assigned but its value is never used|
|[CS0220](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0220)|Error|The operation overflows at compile time in checked mode|
|[CS0221](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0221)|Error|Constant value '{0}' cannot be converted to a '{1}' (use 'unchecked' syntax to override)|
|CS0224|Error|A method with vararg cannot be generic, be in a generic type, or have a params parameter|
|[CS0225](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|The params parameter must have a valid collection type|
|[CS0226](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0226)|Error|An \_\_arglist expression may only appear inside of a call or new expression|
|[CS0227](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0227)|Error|Unsafe code may only appear if compiling with /unsafe|
|[CS0229](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0229)|Error|Ambiguity between '{0}' and '{1}'|
|[CS0230](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0230)|Error|Type and identifier are both required in a foreach statement|
|[CS0231](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|A params parameter must be the last parameter in a parameter list|
|[CS0233](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0233)|Error|'{0}' does not have a predefined size, therefore sizeof can only be used in an unsafe context|
|[CS0234](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The type or namespace name '{0}' does not exist in the namespace '{1}' (are you missing an assembly reference?)|
|[CS0236](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0236)|Error|A field initializer cannot reference the non-static field, method, or property '{0}'|
|[CS0238](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0238)|Error|'{0}' cannot be sealed because it is not an override|
|[CS0239](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0239)|Error|'{0}': cannot override inherited member '{1}' because it is sealed|
|[CS0242](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0242)|Error|The operation in question is undefined on void pointers|
|[CS0243](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0243)|Error|The Conditional attribute is not valid on '{0}' because it is an override method|
|[CS0244](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0244)|Error|Neither 'is' nor 'as' is valid on pointer types|
|[CS0245](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0245)|Error|Destructors and object.Finalize cannot be called directly. Consider calling IDisposable.Dispose if available.|
|[CS0246](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The type or namespace name '{0}' could not be found (are you missing a using directive or an assembly reference?)|
|[CS0247](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0247)|Error|Cannot use a negative size with stackalloc|
|[CS0248](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Cannot create an array with a negative size|
|[CS0249](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0249)|Error|Do not override object.Finalize. Instead, provide a destructor.|
|[CS0250](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0250)|Error|Do not directly call your base type Finalize method. It is called automatically from your destructor.|
|[CS0251](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Warning|Indexing an array with a negative index (array indices always start at zero)|
|[CS0252](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0252)|Warning|Possible unintended reference comparison; to get a value comparison, cast the left hand side to type '{0}'|
|[CS0253](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0253)|Warning|Possible unintended reference comparison; to get a value comparison, cast the right hand side to type '{0}'|
|[CS0254](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0254)|Error|The right hand side of a fixed statement assignment may not be a cast expression|
|[CS0255](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0255)|Error|stackalloc may not be used in a catch or finally block|
|CS0257|Error|An \_\_arglist parameter must be the last parameter in a parameter list|
|[CS0260](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Missing partial modifier on declaration of type '{0}'; another partial declaration of this type exists|
|[CS0261](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial declarations of '{0}' must be all classes, all record classes, all structs, all record structs, or all interfaces|
|[CS0262](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial declarations of '{0}' have conflicting accessibility modifiers|
|[CS0263](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial declarations of '{0}' must not specify different base classes|
|[CS0264](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial declarations of '{0}' must have the same type parameter names in the same order|
|[CS0265](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial declarations of '{0}' have inconsistent constraints for type parameter '{1}'|
|[CS0266](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0266)|Error|Cannot implicitly convert type '{0}' to '{1}'. An explicit conversion exists (are you missing a cast?)|
|[CS0267](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|The 'partial' modifier can only appear immediately before 'class', 'record', 'struct', 'interface', 'event', an instance constructor name, or a method or property return type.|
|[CS0268](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0268)|Error|Imported type '{0}' is invalid. It contains a circular base type dependency.|
|[CS0269](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0269)|Error|Use of unassigned out parameter '{0}'|
|[CS0270](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Array size cannot be specified in a variable declaration (try initializing with a 'new' expression)|
|[CS0271](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0271)|Error|The property or indexer '{0}' cannot be used in this context because the get accessor is inaccessible|
|[CS0272](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0272)|Error|The property or indexer '{0}' cannot be used in this context because the set accessor is inaccessible|
|[CS0273](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0273)|Error|The accessibility modifier of the '{0}' accessor must be more restrictive than the property or indexer '{1}'|
|[CS0274](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0274)|Error|Cannot specify accessibility modifiers for both accessors of the property or indexer '{0}'|
|[CS0276](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0276)|Error|'{0}': accessibility modifiers on accessors may only be used if the property or indexer has both a get and a set accessor|
|[CS0277](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0277)|Error|'{0}' does not implement interface member '{1}'. '{2}' is not public.|
|[CS0278](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0278)|Warning|'{0}' does not implement the '{1}' pattern. '{2}' is ambiguous with '{3}'.|
|[CS0279](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0279)|Warning|'{0}' does not implement the '{1}' pattern. '{2}' is not a public instance or extension method.|
|[CS0280](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0280)|Warning|'{0}' does not implement the '{1}' pattern. '{2}' has the wrong signature.|
|[CS0281](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0281)|Error|Friend access was granted by '{0}', but the public key of the output assembly ('{1}') does not match that specified by the InternalsVisibleTo attribute in the granting assembly.|
|[CS0282](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Warning|There is no defined ordering between fields in multiple declarations of partial struct '{0}'. To specify an ordering, all instance fields must be in the same declaration.|
|[CS0283](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0283)|Error|The type '{0}' cannot be declared const|
|[CS0304](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0304)|Error|Cannot create an instance of the variable type '{0}' because it does not have the new() constraint|
|[CS0305](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0305)|Error|Using the generic {1} '{0}' requires {2} type arguments|
|[CS0306](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0306)|Error|The type '{0}' may not be used as a type argument|
|[CS0307](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0307)|Error|The {1} '{0}' cannot be used with type arguments|
|[CS0308](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0308)|Error|The non-generic {1} '{0}' cannot be used with type arguments|
|[CS0310](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0310)|Error|'{2}' must be a non-abstract type with a public parameterless constructor in order to use it as parameter '{1}' in the generic type or method '{0}'|
|[CS0311](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0311)|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no implicit reference conversion from '{3}' to '{1}'.|
|[CS0312](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0312)|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. The nullable type '{3}' does not satisfy the constraint of '{1}'.|
|[CS0313](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0313)|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. The nullable type '{3}' does not satisfy the constraint of '{1}'. Nullable types can not satisfy any interface constraints.|
|[CS0314](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0314)|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no boxing conversion or type parameter conversion from '{3}' to '{1}'.|
|[CS0315](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0315)|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no boxing conversion from '{3}' to '{1}'.|
|[CS0316](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0316)|Error|The parameter name '{0}' conflicts with an automatically-generated parameter name|
|[CS0400](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The type or namespace name '{0}' could not be found in the global namespace (are you missing an assembly reference?)|
|[CS0401](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0401)|Error|The new() constraint must be the last restrictive constraint specified|
|[CS0402](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0402)|Warning|'{0}': an entry point cannot be generic or in a generic type|
|[CS0403](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0403)|Error|Cannot convert null to type parameter '{0}' because it could be a non-nullable value type. Consider using 'default({0})' instead.|
|[CS0405](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0405)|Error|Duplicate constraint '{0}' for type parameter '{1}'|
|[CS0406](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0406)|Error|The class type constraint '{0}' must come before any other constraints|
|[CS0407](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0407)|Error|'{1} {0}' has the wrong return type|
|[CS0409](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0409)|Error|A constraint clause has already been specified for type parameter '{0}'. All of the constraints for a type parameter must be specified in a single where clause.|
|[CS0411](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0411)|Error|The type arguments for method '{0}' cannot be inferred from the usage. Try specifying the type arguments explicitly.|
|[CS0412](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0412)|Error|'{0}': a parameter, local variable, or local function cannot have the same name as a method type parameter|
|[CS0413](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0413)|Error|The type parameter '{0}' cannot be used with the 'as' operator because it does not have a class type constraint nor a 'class' constraint|
|[CS0414](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0414)|Warning|The field '{0}' is assigned but its value is never used|
|[CS0415](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0415)|Error|The '{0}' attribute is valid only on an indexer that is not an explicit interface member declaration|
|[CS0416](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0416)|Error|'{0}': an attribute argument cannot use type parameters|
|[CS0417](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0417)|Error|'{0}': cannot provide arguments when creating an instance of a variable type|
|[CS0418](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0418)|Error|'{0}': an abstract type cannot be sealed or static|
|[CS0419](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0419)|Warning|Ambiguous reference in cref attribute: '{0}'. Assuming '{1}', but could have also matched other overloads including '{2}'.|
|[CS0420](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0420)|Warning|'{0}': a reference to a volatile field will not be treated as volatile|
|[CS0423](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0423)|Error|Since '{1}' has the ComImport attribute, '{0}' must be extern or abstract|
|[CS0424](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0424)|Error|'{0}': a class with the ComImport attribute cannot specify a base class|
|[CS0425](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0425)|Error|The constraints for type parameter '{0}' of method '{1}' must match the constraints for type parameter '{2}' of interface method '{3}'. Consider using an explicit interface implementation instead.|
|[CS0426](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0426)|Error|The type name '{0}' does not exist in the type '{1}'|
|[CS0428](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0428)|Error|Cannot convert method group '{0}' to non-delegate type '{1}'. Did you intend to invoke the method?|
|[CS0430](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0430)|Error|The extern alias '{0}' was not specified in a /reference option|
|[CS0431](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|Cannot use alias '{0}' with '::' since the alias references a type. Use '.' instead.|
|[CS0432](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|Alias '{0}' not found|
|[CS0433](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0433)|Error|The type '{1}' exists in both '{0}' and '{2}'|
|[CS0434](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0434)|Error|The namespace '{1}' in '{0}' conflicts with the type '{3}' in '{2}'|
|[CS0435](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0435)|Warning|The namespace '{1}' in '{0}' conflicts with the imported type '{3}' in '{2}'. Using the namespace defined in '{0}'.|
|[CS0436](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0436)|Warning|The type '{1}' in '{0}' conflicts with the imported type '{3}' in '{2}'. Using the type defined in '{0}'.|
|[CS0437](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0437)|Warning|The type '{1}' in '{0}' conflicts with the imported namespace '{3}' in '{2}'. Using the type defined in '{0}'.|
|[CS0438](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0438)|Error|The type '{1}' in '{0}' conflicts with the namespace '{3}' in '{2}'|
|[CS0439](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0439)|Error|An extern alias declaration must precede all other elements defined in the namespace|
|[CS0440](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Warning|Defining an alias named 'global' is ill-advised since 'global::' always references the global namespace and not an alias|
|[CS0441](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0441)|Error|'{0}': a type cannot be both static and sealed|
|[CS0442](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0442)|Error|'{0}': abstract properties cannot have private accessors|
|[CS0443](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0443)|Error|Syntax error; value expected|
|[CS0445](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0445)|Error|Cannot modify the result of an unboxing conversion|
|[CS0446](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0446)|Error|Foreach cannot operate on a '{0}'. Did you intend to invoke the '{0}'?|
|[CS0448](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0448)|Error|The return type for ++ or -- operator must match the parameter type or be derived from the parameter type|
|[CS0449](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0449)|Error|The 'class', 'struct', 'unmanaged', 'notnull', and 'default' constraints cannot be combined or duplicated, and must be specified first in the constraints list.|
|[CS0450](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0450)|Error|'{0}': cannot specify both a constraint class and the 'class' or 'struct' constraint|
|[CS0451](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0451)|Error|The 'new()' constraint cannot be used with the 'struct' constraint|
|[CS0452](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0452)|Error|The type '{2}' must be a reference type in order to use it as parameter '{1}' in the generic type or method '{0}'|
|[CS0453](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0453)|Error|The type '{2}' must be a non-nullable value type in order to use it as parameter '{1}' in the generic type or method '{0}'|
|[CS0454](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0454)|Error|Circular constraint dependency involving '{0}' and '{1}'|
|[CS0455](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0455)|Error|Type parameter '{0}' inherits conflicting constraints '{1}' and '{2}'|
|[CS0456](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0456)|Error|Type parameter '{1}' has the 'struct' constraint so '{1}' cannot be used as a constraint for '{0}'|
|[CS0457](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Ambiguous user defined conversions '{0}' and '{1}' when converting from '{2}' to '{3}'|
|[CS0458](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0458)|Warning|The result of the expression is always 'null' of type '{0}'|
|[CS0460](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0460)|Error|Constraints for override and explicit interface implementation methods are inherited from the base method, so they cannot be specified directly, except for either a 'class', or a 'struct' constraint.|
|[CS0462](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0462)|Error|The inherited members '{0}' and '{1}' have the same signature in type '{2}', so they cannot be overridden|
|[CS0463](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0463)|Error|Evaluation of the decimal constant expression failed|
|[CS0464](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0464)|Warning|Comparing with null of type '{0}' always produces 'false'|
|[CS0465](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0465)|Warning|Introducing a 'Finalize' method can interfere with destructor invocation. Did you intend to declare a destructor?|
|[CS0466](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|'{0}' should not have a params parameter since '{1}' does not|
|[CS0469](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0469)|Warning|The 'goto case' value is not implicitly convertible to type '{0}'|
|[CS0470](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0470)|Error|Method '{0}' cannot implement interface accessor '{1}' for type '{2}'. Use an explicit interface implementation.|
|[CS0472](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0472)|Warning|The result of the expression is always '{0}' since a value of type '{1}' is never equal to 'null' of type '{2}'|
|[CS0473](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0473)|Warning|Explicit interface implementation '{0}' matches more than one interface member. Which interface member is actually chosen is implementation-dependent. Consider using a non-explicit implementation instead.|
|[CS0500](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0500)|Error|'{0}' cannot declare a body because it is marked abstract|
|[CS0501](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|'{0}' must declare a body because it is not marked abstract, extern, or partial|
|[CS0502](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0502)|Error|'{0}' cannot be both abstract and sealed|
|[CS0503](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0503)|Error|The abstract {0} '{1}' cannot be marked virtual|
|[CS0504](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0504)|Error|The constant '{0}' cannot be marked static|
|[CS0505](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0505)|Error|'{0}': cannot override because '{1}' is not a function|
|[CS0506](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0506)|Error|'{0}': cannot override inherited member '{1}' because it is not marked virtual, abstract, or override|
|[CS0507](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0507)|Error|'{0}': cannot change access modifiers when overriding '{1}' inherited member '{2}'|
|[CS0508](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0508)|Error|'{0}': return type must be '{2}' to match overridden member '{1}'|
|[CS0509](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0509)|Error|'{0}': cannot derive from sealed type '{1}'|
|[CS0513](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0513)|Error|'{0}' is abstract but it is contained in non-abstract type '{1}'|
|[CS0514](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|'{0}': static constructor cannot have an explicit 'this' or 'base' constructor call|
|[CS0515](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|'{0}': access modifiers are not allowed on static constructors|
|[CS0516](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Constructor '{0}' cannot call itself|
|[CS0517](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|'{0}' has no base class and cannot call a base constructor|
|[CS0518](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0518)|Error|Predefined type '{0}' is not defined or imported|
|[CS0522](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|'{0}': structs cannot call base class constructors|
|[CS0523](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0523)|Error|Struct member '{0}' of type '{1}' causes a cycle in the struct layout|
|[CS0525](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0525)|Error|Interfaces cannot contain instance fields|
|[CS0526](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Interfaces cannot contain instance constructors|
|[CS0527](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0527)|Error|Type '{0}' in interface list is not an interface|
|[CS0528](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0528)|Error|'{0}' is already listed in interface list|
|[CS0529](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0529)|Error|Inherited interface '{1}' causes a cycle in the interface hierarchy of '{0}'|
|[CS0533](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0533)|Error|'{0}' hides inherited abstract member '{1}'|
|[CS0534](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0534)|Error|'{0}' does not implement inherited abstract member '{1}'|
|[CS0535](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0535)|Error|'{0}' does not implement interface member '{1}'|
|[CS0537](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0537)|Error|The class System.Object cannot have a base class or implement an interface|
|[CS0538](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0538)|Error|'{0}' in explicit interface declaration is not an interface|
|[CS0539](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0539)|Error|'{0}' in explicit interface declaration is not found among members of the interface that can be implemented|
|[CS0540](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0540)|Error|'{0}': containing type does not implement interface '{1}'|
|[CS0541](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0541)|Error|'{0}': explicit interface declaration can only be declared in a class, record, struct or interface|
|[CS0542](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0542)|Error|'{0}': member names cannot be the same as their enclosing type|
|[CS0543](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0543)|Error|'{0}': the enumerator value is too large to fit in its type|
|[CS0544](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0544)|Error|'{0}': cannot override because '{1}' is not a property|
|[CS0545](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0545)|Error|'{0}': cannot override because '{1}' does not have an overridable get accessor|
|[CS0546](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0546)|Error|'{0}': cannot override because '{1}' does not have an overridable set accessor|
|[CS0547](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0547)|Error|'{0}': property or indexer cannot have void type|
|[CS0548](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0548)|Error|'{0}': property or indexer must have at least one accessor|
|[CS0549](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0549)|Error|'{0}' is a new virtual member in sealed type '{1}'|
|[CS0550](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0550)|Error|'{0}' adds an accessor not found in interface member '{1}'|
|[CS0551](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0551)|Error|Explicit interface implementation '{0}' is missing accessor '{1}'|
|[CS0552](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0552)|Error|'{0}': user-defined conversions to or from an interface are not allowed|
|[CS0553](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0553)|Error|'{0}': user-defined conversions to or from a base type are not allowed|
|[CS0554](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0554)|Error|'{0}': user-defined conversions to or from a derived type are not allowed|
|[CS0555](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0555)|Error|User-defined operator cannot convert a type to itself|
|[CS0556](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0556)|Error|User-defined conversion must convert to or from the enclosing type|
|[CS0557](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0557)|Error|Duplicate user-defined conversion in type '{0}'|
|[CS0558](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0558)|Error|User-defined operator '{0}' must be declared static and public|
|[CS0559](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0559)|Error|The parameter type for ++ or -- operator must be the containing type|
|[CS0562](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0562)|Error|The parameter of a unary operator must be the containing type|
|[CS0563](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0563)|Error|One of the parameters of a binary operator must be the containing type|
|[CS0564](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0564)|Error|The first operand of an overloaded shift operator must have the same type as the containing type|
|[CS0567](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0567)|Error|Conversion, equality, or inequality operators declared in interfaces must be abstract or virtual|
|[CS0569](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0569)|Error|'{0}': cannot override '{1}' because it is not supported by the language|
|[CS0570](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0570)|Error|'{0}' is not supported by the language|
|[CS0571](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0571)|Error|'{0}': cannot explicitly call operator or accessor|
|[CS0572](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0572)|Error|'{0}': cannot reference a type through an expression; try '{1}' instead|
|[CS0574](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0574)|Error|Name of destructor must match name of type|
|[CS0575](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0575)|Error|Only class types can contain destructors|
|[CS0576](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|Namespace '{1}' contains a definition conflicting with alias '{0}'|
|[CS0577](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0577)|Error|The Conditional attribute is not valid on '{0}' because it is a constructor, destructor, operator, lambda expression, or explicit interface implementation|
|[CS0578](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0578)|Error|The Conditional attribute is not valid on '{0}' because its return type is not void|
|[CS0579](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0579)|Error|Duplicate '{0}' attribute|
|[CS0582](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0582)|Error|The Conditional attribute is not valid on interface members|
|[CS0590](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0590)|Error|User-defined operators cannot return void|
|[CS0591](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Invalid value for argument to '{0}' attribute|
|[CS0592](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0592)|Error|Attribute '{0}' is not valid on this declaration type. It is only valid on '{1}' declarations.|
|[CS0594](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0594)|Error|Floating-point constant is outside the range of type '{0}'|
|CS0595|Error|Invalid real literal.|
|[CS0596](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0596)|Error|The Guid attribute must be specified with the ComImport attribute|
|[CS0599](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Invalid value for named attribute argument '{0}'|
|[CS0601](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0601)|Error|The DllImport attribute must be specified on a method marked 'static' and 'extern'|
|[CS0610](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0610)|Error|Field or property cannot be of type '{0}'|
|[CS0611](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Array elements cannot be of type '{0}'|
|[CS0612](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0612)|Warning|'{0}' is obsolete|
|[CS0616](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0616)|Error|'{0}' is not an attribute class|
|[CS0617](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|'{0}' is not a valid named attribute argument. Named attribute arguments must be fields which are not readonly, static, or const, or read-write properties which are public and not static.|
|[CS0618](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0618)|Warning|'{0}' is obsolete: '{1}'|
|[CS0619](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0619)|Error|'{0}' is obsolete: '{1}'|
|[CS0620](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0620)|Error|Indexers cannot have void type|
|[CS0621](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0621)|Error|'{0}': virtual or abstract members cannot be private|
|[CS0622](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0622)|Error|Can only use array initializer expressions to assign to array types. Try using a new expression instead.|
|[CS0623](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Array initializers can only be used in a variable or field initializer. Try using a new expression instead.|
|[CS0625](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0625)|Error|'{0}': instance field in types marked with StructLayout(LayoutKind.Explicit) must have a FieldOffset attribute|
|[CS0626](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0626)|Warning|Method, operator, or accessor '{0}' is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation.|
|[CS0628](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0628)|Warning|'{0}': new protected member declared in sealed type|
|[CS0629](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0629)|Error|Conditional member '{0}' cannot implement interface member '{1}' in type '{2}'|
|CS0630|Error|'{0}' cannot implement interface member '{1}' in type '{2}' because it has an \_\_arglist parameter|
|[CS0631](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|ref and out are not valid in this context|
|[CS0633](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|The argument to the '{0}' attribute must be a valid identifier|
|[CS0636](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0636)|Error|The FieldOffset attribute can only be placed on members of types marked with the StructLayout(LayoutKind.Explicit)|
|[CS0637](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0637)|Error|The FieldOffset attribute is not allowed on static or const fields|
|[CS0641](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0641)|Error|Attribute '{0}' is only valid on classes derived from System.Attribute|
|[CS0642](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0642)|Warning|Possible mistaken empty statement|
|[CS0643](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|'{0}' duplicate named attribute argument|
|[CS0644](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0644)|Error|'{0}' cannot derive from special class '{1}'|
|[CS0646](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0646)|Error|Cannot specify the DefaultMember attribute on a type containing an indexer|
|[CS0648](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0648)|Error|'{0}' is a type not supported by the language|
|[CS0649](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0649)|Warning|Field '{0}' is never assigned to, and will always have its default value {1}|
|[CS0650](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Bad array declarator: To declare a managed array the rank specifier precedes the variable's identifier. To declare a fixed size buffer field, use the fixed keyword before the field type.|
|[CS0652](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0652)|Warning|Comparison to integral constant is useless; the constant is outside the range of type '{0}'|
|[CS0653](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0653)|Error|Cannot apply attribute class '{0}' because it is abstract|
|[CS0655](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|'{0}' is not a valid named attribute argument because it is not a valid attribute parameter type|
|[CS0656](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0656)|Error|Missing compiler required member '{0}.{1}'|
|[CS0657](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0657)|Warning|'{0}' is not a valid attribute location for this declaration. Valid attribute locations for this declaration are '{1}'. All attributes in this block will be ignored.|
|[CS0658](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0658)|Warning|'{0}' is not a recognized attribute location. Valid attribute locations for this declaration are '{1}'. All attributes in this block will be ignored.|
|[CS0659](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0659)|Warning|'{0}' overrides Object.Equals(object o) but does not override Object.GetHashCode()|
|[CS0660](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0660)|Warning|'{0}' defines operator == or operator != but does not override Object.Equals(object o)|
|[CS0661](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0661)|Warning|'{0}' defines operator == or operator != but does not override Object.GetHashCode()|
|[CS0662](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0662)|Error|Cannot specify the Out attribute on a ref parameter without also specifying the In attribute.|
|[CS0663](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|'{0}' cannot define an overloaded {1} that differs only on parameter modifiers '{2}' and '{3}'|
|[CS0664](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0664)|Error|Literal of type double cannot be implicitly converted to type '{1}'; use an '{0}' suffix to create a literal of this type|
|[CS0665](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0665)|Warning|Assignment in conditional expression is always constant; did you mean to use == instead of = ?|
|[CS0666](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0666)|Error|'{0}': new protected member declared in struct|
|[CS0668](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0668)|Error|Two indexers have different names; the IndexerName attribute must be used with the same name on every indexer within a type|
|[CS0669](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0669)|Error|A class with the ComImport attribute cannot have a user-defined constructor|
|[CS0670](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0670)|Error|Field cannot have void type|
|[CS0672](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0672)|Warning|Member '{0}' overrides obsolete member '{1}'. Add the Obsolete attribute to '{0}'.|
|[CS0673](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0673)|Error|System.Void cannot be used from C# -- use typeof(void) to get the void type object|
|[CS0674](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|Do not use 'System.ParamArrayAttribute'/'System.Runtime.CompilerServices.ParamCollectionAttribute'. Use the 'params' keyword instead.|
|[CS0675](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0675)|Warning|Bitwise-or operator used on a sign-extended operand; consider casting to a smaller unsigned type first|
|[CS0677](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0677)|Error|'{0}': a volatile field cannot be of the type '{1}'|
|[CS0678](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0678)|Error|'{0}': a field cannot be both volatile and readonly|
|[CS0681](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0681)|Error|The modifier 'abstract' is not valid on fields. Try using a property instead.|
|[CS0682](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0682)|Error|'{0}' cannot implement '{1}' because it is not supported by the language|
|[CS0683](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0683)|Error|'{0}' explicit method implementation cannot implement '{1}' because it is an accessor|
|[CS0684](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0684)|Warning|'{0}' interface marked with 'CoClassAttribute' not marked with 'ComImportAttribute'|
|[CS0685](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0685)|Error|Conditional member '{0}' cannot have an out parameter|
|[CS0686](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0686)|Error|Accessor '{0}' cannot implement interface member '{1}' for type '{2}'. Use an explicit interface implementation.|
|[CS0687](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|The namespace alias qualifier '::' always resolves to a type or namespace so is illegal here. Consider using '.' instead.|
|[CS0689](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0689)|Error|Cannot derive from '{0}' because it is a type parameter|
|[CS0692](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0692)|Error|Duplicate type parameter '{0}'|
|[CS0693](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0693)|Warning|Type parameter '{0}' has the same name as the type parameter from outer type '{1}'|
|[CS0694](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0694)|Error|Type parameter '{0}' has the same name as the containing type, or method|
|[CS0695](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0695)|Error|'{0}' cannot implement both '{1}' and '{2}' because they may unify for some type parameter substitutions|
|[CS0699](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0699)|Error|'{1}' does not define type parameter '{0}'|
|[CS0701](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0701)|Error|'{0}' is not a valid constraint. A type used as a constraint must be an interface, a non-sealed class or a type parameter.|
|[CS0702](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0702)|Error|Constraint cannot be special class '{0}'|
|[CS0703](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0703)|Error|Inconsistent accessibility: constraint type '{1}' is less accessible than '{0}'|
|[CS0704](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0704)|Error|Cannot do non-virtual member lookup in '{0}' because it is a type parameter|
|[CS0706](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0706)|Error|Invalid constraint type. A type used as a constraint must be an interface, a non-sealed class or a type parameter.|
|[CS0708](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0708)|Error|'{0}': cannot declare instance members in a static class|
|[CS0709](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0709)|Error|'{1}': cannot derive from static class '{0}'|
|[CS0710](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Static classes cannot have instance constructors|
|[CS0711](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0711)|Error|Static classes cannot contain destructors|
|[CS0712](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0712)|Error|Cannot create an instance of the static class '{0}'|
|[CS0713](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0713)|Error|Static class '{0}' cannot derive from type '{1}'. Static classes must derive from object.|
|[CS0714](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0714)|Error|'{0}': static classes cannot implement interfaces|
|[CS0715](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0715)|Error|'{0}': static classes cannot contain user-defined operators|
|[CS0716](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0716)|Error|Cannot convert to static type '{0}'|
|[CS0717](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0717)|Error|'{0}': static classes cannot be used as constraints|
|[CS0718](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0718)|Error|'{0}': static types cannot be used as type arguments|
|[CS0719](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|'{0}': array elements cannot be of static type|
|[CS0720](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0720)|Error|'{0}': cannot declare indexers in a static class|
|[CS0721](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0721)|Error|'{0}': static types cannot be used as parameters|
|[CS0722](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0722)|Error|'{0}': static types cannot be used as return types|
|[CS0723](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0723)|Error|Cannot declare a variable of static type '{0}'|
|[CS0724](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0724)|Error|A throw statement with no arguments is not allowed in a finally clause that is nested inside the nearest enclosing catch clause|
|[CS0726](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0726)|Error|'{0}' is not a valid format specifier|
|[CS0728](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0728)|Warning|Possibly incorrect assignment to local '{0}' which is the argument to a using or lock statement. The Dispose call or unlocking will happen on the original value of the local.|
|[CS0729](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0729)|Error|Type '{0}' is defined in this assembly, but a type forwarder is specified for it|
|[CS0730](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0730)|Error|Cannot forward type '{0}' because it is a nested type of '{1}'|
|[CS0731](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0731)|Error|The type forwarder for type '{0}' in assembly '{1}' causes a cycle|
|[CS0734](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0734)|Error|The /moduleassemblyname option may only be specified when building a target type of 'module'|
|[CS0735](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0735)|Error|Invalid type specified as an argument for TypeForwardedTo attribute|
|[CS0736](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0736)|Error|'{0}' does not implement instance interface member '{1}'. '{2}' cannot implement the interface member because it is static.|
|[CS0737](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0737)|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement an interface member because it is not public.|
|[CS0738](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0738)|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because it does not have the matching return type of '{3}'.|
|[CS0739](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0739)|Error|'{0}' duplicate TypeForwardedToAttribute|
|[CS0742](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0742)|Error|A query body must end with a select clause or a group clause|
|[CS0743](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0743)|Error|Expected contextual keyword 'on'|
|[CS0744](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0744)|Error|Expected contextual keyword 'equals'|
|[CS0745](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0745)|Error|Expected contextual keyword 'by'|
|[CS0746](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0746)|Error|Invalid anonymous type member declarator. Anonymous type members must be declared with a member assignment, simple name or member access.|
|[CS0747](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Invalid initializer member declarator|
|[CS0748](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Inconsistent lambda parameter usage; parameter types must be all explicit or all implicit|
|[CS0750](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|A partial member cannot have the 'abstract' modifier|
|[CS0751](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|A partial member must be declared within a partial type|
|[CS0754](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|A partial member may not explicitly implement an interface member|
|[CS0755](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial method declarations must be extension methods or neither may be an extension method|
|[CS0756](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|A partial method may not have multiple defining declarations|
|[CS0757](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|A partial method may not have multiple implementing declarations|
|[CS0758](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|Both partial member declarations must use a params parameter or neither may use a params parameter|
|[CS0759](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|No defining declaration found for implementing declaration of partial method '{0}'|
|[CS0761](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial method declarations of '{0}' have inconsistent constraints for type parameter '{1}'|
|[CS0762](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Cannot create delegate from method '{0}' because it is a partial method without an implementing declaration|
|[CS0763](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial member declarations must be static or neither may be static|
|[CS0764](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial member declarations must be unsafe or neither may be unsafe|
|[CS0765](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|Partial methods with only a defining declaration or removed conditional methods cannot be used in expression trees|
|[CS0767](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot inherit interface '{0}' with the specified type parameters because it causes method '{1}' to contain overloads which differ only on ref and out|
|[CS0768](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Constructor '{0}' cannot call itself through another constructor|
|[CS0809](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0809)|Warning|Obsolete member '{0}' overrides non-obsolete member '{1}'|
|[CS0811](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0811)|Warning|The fully qualified name for '{0}' is too long for debug information. Compile without '/debug' option.|
|[CS0815](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0815)|Error|Cannot assign {0} to an implicitly-typed variable|
|[CS0818](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0818)|Error|Implicitly-typed variables must be initialized|
|[CS0819](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0819)|Error|Implicitly-typed variables cannot have multiple declarators|
|[CS0820](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Cannot initialize an implicitly-typed variable with an array initializer|
|[CS0821](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0821)|Error|Implicitly-typed local variables cannot be fixed|
|[CS0822](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0822)|Error|Implicitly-typed variables cannot be constant|
|[CS0824](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Warning|Constructor '{0}' is marked external|
|[CS0825](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0825)|Error|The contextual keyword 'var' may only appear within a local variable declaration or in script code|
|[CS0826](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|No best type found for implicitly-typed array|
|[CS0828](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0828)|Error|Cannot assign '{0}' to anonymous type property|
|[CS0831](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a base access|
|[CS0832](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an assignment operator|
|[CS0833](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0833)|Error|An anonymous type cannot have multiple properties with the same name|
|[CS0834](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|A lambda expression with a statement body cannot be converted to an expression tree|
|[CS0835](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|Cannot convert lambda to an expression tree whose type argument '{0}' is not a delegate type|
|[CS0836](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0836)|Error|Cannot use anonymous type in a constant expression|
|[CS0837](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0837)|Error|The first operand of an 'is' or 'as' operator may not be a lambda expression, anonymous method, or method group.|
|[CS0838](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a multidimensional array initializer|
|[CS0839](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Argument missing|
|[CS0841](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0841)|Error|Cannot use local variable '{0}' before it is declared|
|[CS0843](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Auto-implemented property '{0}' must be fully assigned before control is returned to the caller. Consider updating to language version '{1}' to auto-default the property.|
|[CS0844](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0844)|Error|Cannot use local variable '{0}' before it is declared. The declaration of the local variable hides the field '{1}'.|
|[CS0845](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree lambda may not contain a coalescing operator with a null or default literal left-hand side|
|[CS0846](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|A nested array initializer is expected|
|CS0847|Error|An array initializer of length '{0}' is expected|
|[CS0853](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a named argument specification|
|[CS0854](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a call or invocation that uses optional arguments|
|[CS0855](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an indexed property|
|CS0856|Error|Indexed property '{0}' has non-optional arguments which must be provided|
|CS0857|Error|Indexed property '{0}' must have all arguments optional|
|[CS1001](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1001)|Error|Identifier expected|
|[CS1002](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1002)|Error|; expected|
|[CS1003](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1003)|Error|Syntax error, '{0}' expected|
|[CS1004](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1004)|Error|Duplicate '{0}' modifier|
|[CS1007](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Property accessor already defined|
|[CS1008](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1008)|Error|Type byte, sbyte, short, ushort, int, uint, long, or ulong expected|
|[CS1009](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1009)|Error|Unrecognized escape sequence|
|[CS1010](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1010)|Error|Newline in constant|
|[CS1011](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1011)|Error|Empty character literal|
|[CS1012](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1012)|Error|Too many characters in character literal|
|[CS1013](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1013)|Error|Invalid number|
|[CS1014](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1014)|Error|A get or set accessor expected|
|[CS1015](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1015)|Error|An object, string, or class type expected|
|[CS1016](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Named attribute argument expected|
|[CS1017](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1017)|Error|Catch clauses cannot follow the general catch clause of a try statement|
|[CS1018](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1018)|Error|Keyword 'this' or 'base' expected|
|[CS1019](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Overloadable unary operator expected|
|[CS1020](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Overloadable binary operator expected|
|[CS1021](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1021)|Error|Integral constant is too large|
|[CS1022](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1022)|Error|Type or namespace definition, or end-of-file expected|
|[CS1023](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1023)|Error|Embedded statement cannot be a declaration or labeled statement|
|[CS1024](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1024)|Error|Preprocessor directive expected|
|[CS1025](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1025)|Error|Single-line comment or end-of-line expected|
|[CS1026](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1026)|Error|) expected|
|[CS1027](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1027)|Error|#endif directive expected|
|[CS1028](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1028)|Error|Unexpected preprocessor directive|
|[CS1029](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1029)|Error|#error: '{0}'|
|[CS1030](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1030)|Warning|#warning: '{0}'|
|[CS1031](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1031)|Error|Type expected|
|[CS1032](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1032)|Error|Cannot define/undefine preprocessor symbols after first token in file|
|[CS1035](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1035)|Error|End-of-file found, '\*/' expected|
|[CS1037](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1037)|Error|Overloadable operator expected|
|[CS1038](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1038)|Error|#endregion directive expected|
|[CS1039](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1039)|Error|Unterminated string literal|
|[CS1040](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1040)|Error|Preprocessor directives must appear as the first non-whitespace character on a line|
|[CS1041](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1041)|Error|Identifier expected; '{1}' is a keyword|
|[CS1043](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1043)|Error|{ or ; expected|
|[CS1044](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1044)|Error|Cannot use more than one type in a for, using, fixed, or declaration statement|
|[CS1055](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1055)|Error|An add or remove accessor expected|
|[CS1056](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1056)|Error|Unexpected character '{0}'|
|[CS1057](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1057)|Error|'{0}': static classes cannot contain protected members|
|[CS1058](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1058)|Warning|A previous catch clause already catches all exceptions. All non-exceptions thrown will be wrapped in a System.Runtime.CompilerServices.RuntimeWrappedException.|
|[CS1059](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1059)|Error|The operand of an increment or decrement operator must be a variable, property or indexer|
|[CS1061](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1061)|Error|'{0}' does not contain a definition for '{1}' and no accessible extension method '{1}' accepting a first argument of type '{0}' could be found (are you missing a using directive or an assembly reference?)|
|[CS1062](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Warning|The best overloaded Add method '{0}' for the collection initializer element is obsolete. {1}|
|[CS1063](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|The best overloaded Add method '{0}' for the collection initializer element is obsolete. {1}|
|[CS1064](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Warning|The best overloaded Add method '{0}' for the collection initializer element is obsolete.|
|[CS1065](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1065)|Error|Default values are not valid in this context.|
|CS1066|Warning|The default value specified for parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments|
|[CS1067](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial declarations of '{0}' must have the same type parameter names and variance modifiers in the same order|
|[CS1068](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The type name '{0}' could not be found in the global namespace. This type has been forwarded to assembly '{1}' Consider adding a reference to that assembly.|
|[CS1069](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The type name '{0}' could not be found in the namespace '{1}'. This type has been forwarded to assembly '{2}' Consider adding a reference to that assembly.|
|[CS1070](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The type name '{0}' could not be found. This type has been forwarded to assembly '{1}'. Consider adding a reference to that assembly.|
|CS1072|Warning|Expected identifier or numeric literal.|
|CS1073|Error|Unexpected token '{0}'|
|[CS1100](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1100)|Error|Method '{0}' has a parameter modifier 'this' which is not on the first parameter|
|[CS1103](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1103)|Error|The receiver parameter of an extension cannot be of type '{0}'|
|[CS1104](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|A parameter array cannot be used with 'this' modifier on an extension method|
|[CS1105](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1105)|Error|Extension method must be static|
|[CS1106](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1106)|Error|Extension method must be defined in a non-generic static class|
|[CS1107](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1107)|Error|A parameter can only have one '{0}' modifier|
|[CS1109](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1109)|Error|Extension methods must be defined in a top level static class; {0} is a nested class|
|[CS1110](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1110)|Error|Cannot define a new extension because the compiler required type '{0}' cannot be found. Are you missing a reference to System.Core.dll?|
|[CS1112](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1112)|Error|Do not use 'System.Runtime.CompilerServices.ExtensionAttribute'. Use the 'this' keyword instead.|
|[CS1113](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1113)|Error|Extension method '{0}' defined on value type '{1}' cannot be used to create delegates|
|[CS1501](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|No overload for method '{0}' takes {1} arguments|
|[CS1503](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1503)|Error|Argument {0}: cannot convert from '{1}' to '{2}'|
|[CS1504](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1504)|Error|Source file '{0}' could not be opened -- {1}|
|[CS1507](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1507)|Error|Cannot link resource files when building a module|
|[CS1508](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1508)|Error|Resource identifier '{0}' has already been used in this assembly|
|[CS1509](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1509)|Error|The referenced file '{0}' is not an assembly|
|[CS1510](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|A ref or out value must be an assignable variable|
|[CS1511](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1511)|Error|Keyword 'base' is not available in a static method|
|[CS1512](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1512)|Error|Keyword 'base' is not available in the current context|
|[CS1513](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1513)|Error|} expected|
|[CS1514](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1514)|Error|{ expected|
|[CS1515](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1515)|Error|'in' expected|
|[CS1517](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1517)|Error|Invalid preprocessor expression|
|[CS1519](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1519)|Error|Invalid token '{0}' in a member declaration|
|[CS1520](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1520)|Error|Method must have a return type|
|[CS1521](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1521)|Error|Invalid base type|
|[CS1522](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1522)|Warning|Empty switch block|
|[CS1524](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1524)|Error|Expected catch or finally|
|[CS1525](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1525)|Error|Invalid expression term '{0}'|
|[CS1526](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1526)|Error|A new expression requires an argument list or (), [], or {} after type|
|[CS1527](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1527)|Error|Elements defined in a namespace cannot be explicitly declared as private, protected, protected internal, or private protected|
|[CS1528](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1528)|Error|Expected ; or = (cannot specify constructor arguments in declaration)|
|[CS1529](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|A using clause must precede all other elements defined in the namespace except extern alias declarations|
|[CS1534](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Overloaded binary operator '{0}' takes two parameters|
|[CS1535](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Overloaded unary operator '{0}' takes one parameter|
|[CS1536](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1536)|Error|Invalid parameter type 'void'|
|[CS1537](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|The using alias '{0}' appeared previously in this namespace|
|[CS1540](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1540)|Error|Cannot access protected member '{0}' via a qualifier of type '{1}'; the qualifier must be of type '{2}' (or derived from it)|
|[CS1542](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1542)|Error|'{0}' cannot be added to this assembly because it already is an assembly|
|[CS1545](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1545)|Error|Property, indexer, or event '{0}' is not supported by the language; try directly calling accessor methods '{1}' or '{2}'|
|[CS1546](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1546)|Error|Property, indexer, or event '{0}' is not supported by the language; try directly calling accessor method '{1}'|
|[CS1547](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1547)|Error|Keyword 'void' cannot be used in this context|
|[CS1551](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1551)|Error|Indexers must have at least one parameter|
|[CS1552](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Array type specifier, [], must appear before parameter name|
|[CS1553](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1553)|Error|Declaration is not valid; use '{0} operator \<dest-type\> (...' instead|
|[CS1555](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1555)|Error|Could not find '{0}' specified for Main method|
|[CS1556](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1556)|Error|'{0}' specified for Main method must be a non-generic class, record, struct, or interface|
|[CS1558](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1558)|Error|'{0}' does not have a suitable static 'Main' method|
|[CS1562](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1562)|Error|Outputs without source must have the /out option specified|
|[CS1564](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1564)|Error|Conflicting options specified: Win32 resource file; Win32 manifest|
|[CS1565](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1565)|Error|Conflicting options specified: Win32 resource file; Win32 icon|
|[CS1566](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1566)|Error|Error reading resource '{0}' -- '{1}'|
|[CS1569](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1569)|Error|Error writing to XML documentation file: {0}|
|[CS1570](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1570)|Warning|XML comment has badly formed XML -- '{0}'|
|[CS1571](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1571)|Warning|XML comment has a duplicate param tag for '{0}'|
|[CS1572](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1572)|Warning|XML comment has a param tag for '{0}', but there is no parameter by that name|
|[CS1573](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1573)|Warning|Parameter '{0}' has no matching param tag in the XML comment for '{1}' (but other parameters do)|
|[CS1574](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1574)|Warning|XML comment has cref attribute '{0}' that could not be resolved|
|[CS1575](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1575)|Error|A stackalloc expression requires [] after type|
|[CS1576](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1576)|Error|The line number specified for #line directive is missing or invalid|
|[CS1578](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1578)|Error|Quoted file name, single-line comment or end-of-line expected|
|[CS1579](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1579)|Error|foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'|
|[CS1580](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1580)|Warning|Invalid type for parameter {0} in XML comment cref attribute: '{1}'|
|[CS1581](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1581)|Warning|Invalid return type in XML comment cref attribute|
|[CS1583](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1583)|Error|Error reading Win32 resources -- {0}|
|[CS1584](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1584)|Warning|XML comment has syntactically incorrect cref attribute '{0}'|
|[CS1585](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1585)|Error|Member modifier '{0}' must precede the member type and name|
|[CS1586](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Array creation must have array size or array initializer|
|[CS1587](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1587)|Warning|XML comment is not placed on a valid language element|
|[CS1589](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1589)|Warning|Unable to include XML fragment '{1}' of file '{0}' -- {2}|
|[CS1590](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1590)|Warning|Invalid XML include element -- {0}|
|[CS1591](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1591)|Warning|Missing XML comment for publicly visible type or member '{0}'|
|[CS1592](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1592)|Warning|Badly formed XML in included comments file -- '{0}'|
|[CS1593](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1593)|Error|Delegate '{0}' does not take {1} arguments|
|[CS1597](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1597)|Error|Semicolon after method or accessor block is not valid|
|[CS1599](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1599)|Error|The return type of a method, delegate, or function pointer cannot be '{0}'|
|[CS1600](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1600)|Error|Compilation cancelled by user|
|[CS1601](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1601)|Error|Cannot make reference to variable of type '{0}'|
|[CS1604](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1604)|Error|Cannot assign to '{0}' because it is read-only|
|[CS1605](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot use '{0}' as a ref or out value because it is read-only|
|[CS1607](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1607)|Warning||
|[CS1608](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1608)|Error|The RequiredAttribute attribute is not permitted on C# types|
|[CS1609](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1609)|Error|Modifiers cannot be placed on event accessor declarations|
|[CS1611](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|The params parameter cannot be declared as {0}|
|[CS1612](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1612)|Error|Cannot modify the return value of '{0}' because it is not a variable|
|[CS1613](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1613)|Error|The managed coclass wrapper class '{0}' for interface '{1}' cannot be found (are you missing an assembly reference?)|
|[CS1614](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1614)|Error|'{0}' is ambiguous between '{1}' and '{2}'. Either use '@{0}' or explicitly include the 'Attribute' suffix.|
|[CS1615](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1615)|Error|Argument {0} may not be passed with the '{1}' keyword|
|[CS1616](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1616)|Warning|Option '{0}' overrides attribute '{1}' given in a source file or added module|
|[CS1617](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1617)|Error|Invalid option '{0}' for /langversion. Use '/langversion:?' to list supported values.|
|[CS1618](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1618)|Error|Cannot create delegate with '{0}' because it or a method it overrides has a Conditional attribute|
|[CS1619](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1619)|Error|Cannot create temporary file -- {0}|
|[CS1620](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1620)|Error|Argument {0} must be passed with the '{1}' keyword|
|[CS1621](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|The yield statement cannot be used inside an anonymous method or lambda expression|
|[CS1622](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|Cannot return a value from an iterator. Use the yield return statement to return a value, or yield break to end the iteration.|
|[CS1623](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Iterators cannot have ref, in or out parameters|
|[CS1624](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|The body of '{0}' cannot be an iterator block because '{1}' is not an iterator interface type|
|[CS1625](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|Cannot yield in the body of a finally clause|
|[CS1626](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|Cannot yield a value in the body of a try block with a catch clause|
|[CS1627](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|Expression expected after yield return|
|[CS1628](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Cannot use ref, out, or in parameter '{0}' inside an anonymous method, lambda expression, query expression, or local function|
|[CS1631](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|Cannot yield a value in the body of a catch clause|
|[CS1632](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Control cannot leave the body of an anonymous method or lambda expression|
|[CS1633](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1633)|Warning|Unrecognized #pragma directive|
|[CS1634](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1634)|Warning|Expected 'disable' or 'restore'|
|[CS1635](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1635)|Warning|Cannot restore warning 'CS{0}' because it was disabled globally|
|CS1636|Error|\_\_arglist is not allowed in the parameter list of iterators|
|[CS1637](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|Iterators cannot have pointer type parameters|
|[CS1639](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1639)|Error|The managed coclass wrapper class signature '{0}' for interface '{1}' is not a valid class name signature|
|[CS1640](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1640)|Error|foreach statement cannot operate on variables of type '{0}' because it implements multiple instantiations of '{1}'; try casting to a specific interface instantiation|
|[CS1641](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1641)|Error|A fixed size buffer field must have the array size specifier after the field name|
|[CS1642](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1642)|Error|Fixed size buffer fields may only be members of structs|
|[CS1643](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1643)|Error|Not all code paths return a value in {0} of type '{1}'|
|[CS1645](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1645)|Warning|Feature '{0}' is not part of the standardized ISO C# language specification, and may not be accepted by other compilers|
|[CS1646](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1646)|Error|Keyword, identifier, or string expected after verbatim specifier: @|
|[CS1648](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1648)|Error|Members of readonly field '{0}' cannot be modified (except in a constructor or a variable initializer)|
|[CS1649](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Members of readonly field '{0}' cannot be used as a ref or out value (except in a constructor)|
|[CS1650](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1650)|Error|Fields of static readonly field '{0}' cannot be assigned to (except in a static constructor or a variable initializer)|
|[CS1651](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Fields of static readonly field '{0}' cannot be used as a ref or out value (except in a static constructor)|
|[CS1654](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1654)|Error|Cannot modify members of '{0}' because it is a '{1}'|
|[CS1655](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot use fields of '{0}' as a ref or out value because it is a '{1}'|
|[CS1656](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1656)|Error|Cannot assign to '{0}' because it is a '{1}'|
|[CS1657](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot use '{0}' as a ref or out value because it is a '{1}'|
|[CS1658](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1658)|Warning|{0}. See also error CS{1}.|
|[CS1660](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1660)|Error|Cannot convert {0} to type '{1}' because it is not a delegate type|
|[CS1661](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1661)|Error|Cannot convert {0} to type '{1}' because the parameter types do not match the delegate parameter types|
|[CS1662](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1662)|Error|Cannot convert {0} to intended delegate type because some of the return types in the block are not implicitly convertible to the delegate return type|
|[CS1663](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1663)|Error|Fixed size buffer type must be one of the following: bool, byte, short, int, long, char, sbyte, ushort, uint, ulong, float or double|
|[CS1664](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1664)|Error|Fixed size buffer of length {0} and type '{1}' is too big|
|[CS1665](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1665)|Error|Fixed size buffers must have a length greater than zero|
|[CS1666](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1666)|Error|You cannot use fixed size buffers contained in unfixed expressions. Try using the fixed statement.|
|[CS1667](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1667)|Error|Attribute '{0}' is not valid on property or event accessors. It is only valid on '{1}' declarations.|
|[CS1668](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1668)|Warning|Invalid search path '{0}' specified in '{1}' -- '{2}'|
|CS1669|Error|\_\_arglist is not valid in this context|
|[CS1670](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|params is not valid in this context|
|[CS1671](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1671)|Error|A namespace declaration cannot have modifiers or attributes|
|[CS1672](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1672)|Error|Invalid option '{0}' for /platform; must be anycpu, x86, Itanium, arm, arm64 or x64|
|[CS1673](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Anonymous methods, lambda expressions, query expressions, and local functions inside structs cannot access instance members of 'this'. Consider copying 'this' to a local variable outside the anonymous method, lambda expression, query expression, or local function and using the local instead.|
|[CS1674](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1674)|Error|'{0}': type used in a using statement must implement 'System.IDisposable'.|
|[CS1676](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1676)|Error|Parameter {0} must be declared with the '{1}' keyword|
|[CS1677](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1677)|Error|Parameter {0} should not be declared with the '{1}' keyword|
|[CS1678](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1678)|Error|Parameter {0} is declared as type '{1}{2}' but should be '{3}{4}'|
|[CS1679](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1679)|Error|Invalid extern alias for '/reference'; '{0}' is not a valid identifier|
|[CS1680](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1680)|Error|Invalid reference alias option: '{0}=' -- missing filename|
|[CS1681](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1681)|Error|You cannot redefine the global extern alias|
|[CS1685](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1685)|Warning|The predefined type '{0}' is defined in multiple assemblies in the global alias; using definition from '{1}'|
|[CS1686](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Local '{0}' or its members cannot have their address taken and be used inside an anonymous method or lambda expression|
|[CS1687](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1687)|Warning|Source file has exceeded the limit of 16,707,565 lines representable in the PDB; debug information will be incorrect|
|[CS1688](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1688)|Error|Cannot convert anonymous method block without a parameter list to delegate type '{0}' because it has one or more out parameters|
|[CS1689](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1689)|Error|Attribute '{0}' is only valid on methods or attribute classes|
|[CS1690](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1690)|Warning|Accessing a member on '{0}' may cause a runtime exception because it is a field of a marshal-by-reference class|
|[CS1692](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1692)|Warning|Invalid number|
|[CS1695](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1695)|Warning|Invalid #pragma checksum syntax; should be #pragma checksum "filename" "{XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX}" "XXXX..."|
|[CS1696](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1696)|Warning|Single-line comment or end-of-line expected|
|[CS1697](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1697)|Warning|Different checksum values given for '{0}'|
|[CS1700](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1700)|Warning|Assembly reference '{0}' is invalid and cannot be resolved|
|[CS1701](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1701)|Warning|Assuming assembly reference '{0}' used by '{1}' matches identity '{2}' of '{3}', you may need to supply runtime policy|
|[CS1702](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1702)|Warning|Assuming assembly reference '{0}' used by '{1}' matches identity '{2}' of '{3}', you may need to supply runtime policy|
|[CS1703](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1703)|Error|Multiple assemblies with equivalent identity have been imported: '{0}' and '{1}'. Remove one of the duplicate references.|
|[CS1704](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|An assembly with the same simple name '{0}' has already been imported. Try removing one of the references (e.g. '{1}') or sign them to enable side-by-side.|
|[CS1705](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1705)|Error|Assembly '{0}' with identity '{1}' uses '{2}' which has a higher version than referenced assembly '{3}' with identity '{4}'|
|[CS1708](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1708)|Error|Fixed size buffers can only be accessed through locals or fields|
|[CS1710](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1710)|Warning|XML comment has a duplicate typeparam tag for '{0}'|
|[CS1711](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1711)|Warning|XML comment has a typeparam tag for '{0}', but there is no type parameter by that name|
|[CS1712](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1712)|Warning|Type parameter '{0}' has no matching typeparam tag in the XML comment on '{1}' (but other type parameters do)|
|[CS1715](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1715)|Error|'{0}': type must be '{2}' to match overridden member '{1}'|
|[CS1716](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1716)|Error|Do not use 'System.Runtime.CompilerServices.FixedBuffer' attribute. Use the 'fixed' field modifier instead.|
|[CS1717](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1717)|Warning|Assignment made to same variable; did you mean to assign something else?|
|[CS1718](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1718)|Warning|Comparison made to same variable; did you mean to compare something else?|
|[CS1719](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1719)|Error|Error opening Win32 resource file '{0}' -- '{1}'|
|[CS1720](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1720)|Warning|Expression will always cause a System.NullReferenceException because the default value of '{0}' is null|
|[CS1721](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1721)|Error|Class '{0}' cannot have multiple base classes: '{1}' and '{2}'|
|[CS1722](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1722)|Error|Base class '{0}' must come before any interfaces|
|[CS1723](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1723)|Warning|XML comment has cref attribute '{0}' that refers to a type parameter|
|[CS1725](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1725)|Error|Friend assembly reference '{0}' is invalid. InternalsVisibleTo declarations cannot have a version, culture, public key token, or processor architecture specified.|
|[CS1726](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1726)|Error|Friend assembly reference '{0}' is invalid. Strong-name signed assemblies must specify a public key in their InternalsVisibleTo declarations.|
|[CS1728](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1728)|Error|Cannot bind delegate to '{0}' because it is a member of 'System.Nullable\<T\>'|
|[CS1729](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1729)|Error|'{0}' does not contain a constructor that takes {1} arguments|
|[CS1730](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1730)|Error|Assembly and module attributes must precede all other elements defined in a file except using clauses and extern alias declarations|
|[CS1733](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1733)|Error|Expected expression|
|CS1734|Warning|XML comment on '{1}' has a paramref tag for '{0}', but there is no parameter by that name|
|CS1735|Warning|XML comment on '{1}' has a typeparamref tag for '{0}', but there is no type parameter by that name|
|[CS1736](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1736)|Error|Default parameter value for '{0}' must be a compile-time constant|
|[CS1737](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1737)|Error|Optional parameters must appear after all required parameters|
|[CS1738](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Named argument specifications must appear after all fixed arguments have been specified. Please use language version {0} or greater to allow non-trailing named arguments.|
|[CS1739](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|The best overload for '{0}' does not have a parameter named '{1}'|
|[CS1740](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Named argument '{0}' cannot be specified multiple times|
|[CS1741](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|A ref or out parameter cannot have a default value|
|[CS1742](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|An array access may not have a named argument specifier|
|CS1743|Error|Cannot specify a default value for the 'this' parameter|
|[CS1744](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Named argument '{0}' specifies a parameter for which a positional argument has already been given|
|CS1745|Error|Cannot specify default parameter value in conjunction with DefaultParameterAttribute or OptionalAttribute|
|[CS1746](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|The delegate '{0}' does not have a parameter named '{1}'|
|CS1747|Error|Cannot embed interop types from assembly '{0}' because it is missing the '{1}' attribute.|
|CS1748|Error|Cannot find the interop type that matches the embedded interop type '{0}'. Are you missing an assembly reference?|
|[CS1750](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1750)|Error|A value of type '{0}' cannot be used as a default parameter because there are no standard conversions to type '{1}'|
|[CS1751](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|Cannot specify a default value for a parameter collection|
|CS1752|Error|Interop type '{0}' cannot be embedded. Use the applicable interface instead.|
|CS1754|Error|Type '{0}' cannot be embedded because it is a nested type. Consider setting the 'Embed Interop Types' property to false.|
|CS1756|Error|Interop type '{0}' cannot be embedded because it is missing the required '{1}' attribute.|
|CS1757|Error|Embedded interop struct '{0}' can contain only public instance fields.|
|CS1758|Error|Cannot embed interop type '{0}' found in both assembly '{1}' and '{2}'. Consider setting the 'Embed Interop Types' property to false.|
|CS1759|Error|Cannot embed interop types from assembly '{0}' because it is missing either the '{1}' attribute or the '{2}' attribute.|
|[CS1760](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|Assemblies '{0}' and '{1}' refer to the same metadata but only one is a linked reference (specified using /link option); consider removing one of the references.|
|CS1761|Error|Embedding the interop type '{0}' from assembly '{1}' causes a name clash in the current assembly. Consider setting the 'Embed Interop Types' property to false.|
|[CS1762](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1762)|Warning|A reference was created to embedded interop assembly '{0}' because of an indirect reference to that assembly created by assembly '{1}'. Consider changing the 'Embed Interop Types' property on either assembly.|
|[CS1763](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1763)|Error|'{0}' is of type '{1}'. A default parameter value of a reference type other than string can only be initialized with null|
|CS1764|Error|Cannot use fixed local '{0}' inside an anonymous method, lambda expression, or query expression|
|CS1766|Error|Source interface '{0}' is missing method '{1}' which is required to embed event '{2}'.|
|CS1767|Error|Interface '{0}' has an invalid source interface which is required to embed event '{1}'.|
|CS1768|Error|Type '{0}' cannot be embedded because it has a generic argument. Consider setting the 'Embed Interop Types' property to false.|
|CS1769|Error|Type '{0}' from assembly '{1}' cannot be used across assembly boundaries because it has a generic type argument that is an embedded interop type.|
|CS1770|Error|A value of type '{0}' cannot be used as default parameter for nullable parameter '{1}' because '{0}' is not a simple type|
|CS1773|Error|Invalid version {0} for /subsystemversion. The version must be 6.02 or greater for ARM or AppContainerExe, and 4.00 or greater otherwise|
|CS1774|Error|Embedded interop method '{0}' contains a body.|
|[CS1900](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1900)|Error|Warning level must be zero or greater|
|[CS1902](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1902)|Error|Invalid option '{0}' for /debug; must be 'portable', 'embedded', 'full' or 'pdbonly'|
|[CS1906](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1906)|Error|Invalid option '{0}'; Resource visibility must be either 'public' or 'private'|
|[CS1908](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1908)|Error|The type of the argument to the DefaultParameterValue attribute must match the parameter type|
|[CS1910](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1910)|Error|Argument of type '{0}' is not applicable for the DefaultParameterValue attribute|
|[CS1912](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1912)|Error|Duplicate initialization of member '{0}'|
|[CS1913](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1913)|Error|Member '{0}' cannot be initialized. It is not a field or property.|
|[CS1914](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1914)|Error|Static field or property '{0}' cannot be assigned in an object initializer|
|[CS1917](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1917)|Error|Members of readonly field '{0}' of type '{1}' cannot be assigned with an object initializer because it is of a value type|
|[CS1918](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1918)|Error|Members of property '{0}' of type '{1}' cannot be assigned with an object initializer because it is of a value type|
|[CS1919](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1919)|Error|Unsafe type '{0}' cannot be used in object creation|
|[CS1920](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Element initializer cannot be empty|
|[CS1921](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|The best overloaded method match for '{0}' has wrong signature for the initializer element. The initializable Add must be an accessible instance method.|
|[CS1922](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1922)|Error|Cannot initialize type '{0}' with a collection initializer because it does not implement 'System.Collections.IEnumerable'|
|[CS1926](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1926)|Error|Error opening Win32 manifest file {0} -- {1}|
|[CS1927](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1927)|Warning|Ignoring /win32manifest for module because it only applies to assemblies|
|[CS1929](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|'{0}' does not contain a definition for '{1}' and the best extension method overload '{2}' requires a receiver of type '{3}'|
|[CS1930](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1930)|Error|The range variable '{0}' has already been declared|
|[CS1931](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1931)|Error|The range variable '{0}' conflicts with a previous declaration of '{0}'|
|[CS1932](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1932)|Error|Cannot assign {0} to a range variable|
|[CS1934](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1934)|Error|Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Consider explicitly specifying the type of the range variable '{2}'.|
|[CS1935](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1935)|Error|Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Are you missing required assembly references or a using directive for 'System.Linq'?|
|[CS1936](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1936)|Error|Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.|
|[CS1937](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1937)|Error|The name '{0}' is not in scope on the left side of 'equals'.  Consider swapping the expressions on either side of 'equals'.|
|[CS1938](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1938)|Error|The name '{0}' is not in scope on the right side of 'equals'.  Consider swapping the expressions on either side of 'equals'.|
|[CS1939](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot pass the range variable '{0}' as an out or ref parameter|
|[CS1940](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1940)|Error|Multiple implementations of the query pattern were found for source type '{0}'.  Ambiguous call to '{1}'.|
|[CS1941](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1941)|Error|The type of one of the expressions in the {0} clause is incorrect.  Type inference failed in the call to '{1}'.|
|[CS1942](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1942)|Error|The type of the expression in the {0} clause is incorrect.  Type inference failed in the call to '{1}'.|
|[CS1943](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1943)|Error|An expression of type '{0}' is not allowed in a subsequent from clause in a query expression with source type '{1}'.  Type inference failed in the call to '{2}'.|
|[CS1944](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an unsafe pointer operation|
|[CS1945](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an anonymous method expression|
|[CS1946](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An anonymous method expression cannot be converted to an expression tree|
|[CS1947](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1947)|Error|Range variable '{0}' cannot be assigned to -- it is read only|
|[CS1948](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1948)|Error|The range variable '{0}' cannot have the same name as a method type parameter|
|[CS1949](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1949)|Error|The contextual keyword 'var' cannot be used in a range variable declaration|
|[CS1950](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|The best overloaded Add method '{0}' for the collection initializer has some invalid arguments|
|[CS1951](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree lambda may not contain a ref, in or out parameter|
|[CS1952](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree lambda may not contain a method with variable arguments|
|[CS1954](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|The best overloaded method match '{0}' for the collection initializer element cannot be used. Collection initializer 'Add' methods cannot have ref or out parameters.|
|[CS1955](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1955)|Error|Non-invocable member '{0}' cannot be used like a method.|
|[CS1956](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1956)|Warning|Member '{0}' implements interface member '{1}' in type '{2}'. There are multiple matches for the interface member at run-time. It is implementation dependent which method will be called.|
|[CS1957](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1957)|Warning|Member '{1}' overrides '{0}'. There are multiple override candidates at run-time. It is implementation dependent which method will be called. Please use a newer runtime.|
|[CS1958](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1958)|Error|Object and collection initializer expressions may not be applied to a delegate creation expression|
|[CS1959](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1959)|Error|'{0}' is of type '{1}'. The type specified in a constant declaration must be sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, bool, string, an enum-type, or a reference-type.|
|CS1960|Error|Invalid variance modifier. Only interface and delegate type parameters can be specified as variant.|
|CS1961|Error|Invalid variance: The type parameter '{1}' must be {3} valid on '{0}'. '{1}' is {2}.|
|CS1962|Error|The typeof operator cannot be used on the dynamic type|
|[CS1963](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a dynamic operation|
|CS1964|Error|'{0}': user-defined conversions to or from the dynamic type are not allowed|
|CS1965|Error|'{0}': cannot derive from the dynamic type|
|CS1966|Error|'{0}': cannot implement a dynamic interface '{1}'|
|CS1967|Error|Constraint cannot be the dynamic type|
|CS1968|Error|Constraint cannot be a dynamic type '{0}'|
|CS1969|Error|One or more types required to compile a dynamic expression cannot be found. Are you missing a reference?|
|CS1970|Error|Do not use 'System.Runtime.CompilerServices.DynamicAttribute'. Use the 'dynamic' keyword instead.|
|CS1971|Error|The call to method '{0}' needs to be dynamically dispatched, but cannot be because it is part of a base access expression. Consider casting the dynamic arguments or eliminating the base access.|
|CS1972|Error|The indexer access needs to be dynamically dispatched, but cannot be because it is part of a base access expression. Consider casting the dynamic arguments or eliminating the base access.|
|CS1973|Error|'{0}' has no applicable method named '{1}' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.|
|CS1974|Warning|The dynamically dispatched call to method '{0}' may fail at runtime because one or more applicable overloads are conditional methods.|
|CS1975|Error|The constructor call needs to be dynamically dispatched, but cannot be because it is part of a constructor initializer. Consider casting the dynamic arguments.|
|CS1976|Error|Cannot use a method group as an argument to a dynamically dispatched operation. Did you intend to invoke the method?|
|CS1977|Error|Cannot use a lambda expression as an argument to a dynamically dispatched operation without first casting it to a delegate or expression tree type.|
|CS1978|Error|Cannot use an expression of type '{0}' as an argument to a dynamically dispatched operation.|
|CS1979|Error|Query expressions over source type 'dynamic' or with a join sequence of type 'dynamic' are not allowed|
|CS1980|Error|Cannot define a class or member that utilizes 'dynamic' because the compiler required type '{0}' cannot be found. Are you missing a reference?|
|CS1981|Warning|Using '{0}' to test compatibility with '{1}' is essentially identical to testing compatibility with '{2}' and will succeed for all non-null values|
|[CS1983](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1983)|Error|The return type of an async method must be void, Task, Task\<T\>, a task-like type, IAsyncEnumerable\<T\>, or IAsyncEnumerator\<T\>|
|CS1984|Error|Cannot await in the body of a finally clause|
|CS1985|Error|Cannot await in a catch clause|
|[CS1986](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1986)|Error|'await' requires that the type {0} have a suitable 'GetAwaiter' method|
|[CS1988](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Async methods cannot have ref, in or out parameters|
|[CS1989](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Async lambda expressions cannot be converted to expression trees|
|CS1991|Error|'{0}' cannot implement '{1}' because '{2}' is a Windows Runtime event and '{3}' is a regular .NET event.|
|CS1992|Error|The 'await' operator can only be used when contained within a method or lambda expression marked with the 'async' modifier|
|[CS1994](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1994)|Error|The 'async' modifier can only be used in methods that have a body.|
|CS1995|Error|The 'await' operator may only be used in a query expression within the first collection expression of the initial 'from' clause or within the collection expression of a 'join' clause|
|[CS1996](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1996)|Error|Cannot await in the body of a lock statement|
|[CS1997](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1997)|Error|Since '{0}' is an async method that returns '{1}', a return keyword must not be followed by an object expression|
|CS1998|Warning|This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.|
|[CS2001](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2001)|Error|Source file '{0}' could not be found.|
|[CS2002](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2002)|Warning|Source file '{0}' specified multiple times|
|[CS2005](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2005)|Error|Missing file specification for '{0}' option|
|[CS2006](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2006)|Error|Command-line syntax error: Missing '{0}' for '{1}' option|
|[CS2007](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2007)|Error|Unrecognized option: '{0}'|
|[CS2008](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2008)|Warning|No source files specified.|
|[CS2011](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2011)|Error|Error opening response file '{0}'|
|[CS2012](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2012)|Error|Cannot open '{0}' for writing -- {1}|
|[CS2013](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2013)|Error|Invalid image base number '{0}'|
|[CS2015](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2015)|Error|'{0}' is a binary file instead of a text file|
|[CS2016](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2016)|Fatal|Code page '{0}' is invalid or not installed|
|[CS2017](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2017)|Error|Cannot specify /main if building a module or library|
|[CS2019](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2019)|Fatal|Invalid target type for /target: must specify 'exe', 'winexe', 'library', or 'module'|
|[CS2021](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2021)|Fatal|File name '{0}' is empty, contains invalid characters, has a drive specification without an absolute path, or is too long|
|[CS2023](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2023)|Warning|Ignoring /noconfig option because it was specified in a response file|
|[CS2024](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2024)|Error|Invalid file section alignment '{0}'|
|[CS2029](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2029)|Warning|Invalid name for a preprocessing symbol; '{0}' is not a valid identifier|
|[CS2033](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2033)|Fatal|Cannot create short filename '{0}' when a long filename with the same short filename already exists|
|[CS2034](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2034)|Error|A /reference option that declares an extern alias can only have one filename. To specify multiple aliases or filenames, use multiple /reference options.|
|[CS2035](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2035)|Error|Command-line syntax error: Missing ':\<number\>' for '{0}' option|
|[CS2036](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs2036)|Error|The /pdb option requires that the /debug option also be used|
|[CS2037](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree lambda may not contain a COM call with ref omitted on arguments|
|CS2038|Warning|The language name '{0}' is invalid.|
|CS2039|Error|Command-line syntax error: Invalid Guid format '{0}' for option '{1}'|
|CS2040|Error|Command-line syntax error: Missing Guid for option '{1}'|
|CS2041|Error|Invalid output name: {0}|
|CS2042|Error|Invalid debug information format: {0}|
|CS2043|Error|'id#' syntax is no longer supported. Use '$id' instead.|
|CS2044|Error|/sourcelink switch is only supported when emitting PDB.|
|CS2045|Error|/embed switch is only supported when emitting a PDB.|
|CS2046|Error|Command-line syntax error: '{0}' is not a valid value for the '{1}' option. The value must be of the form '{2}'.|
|[CS3000](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3000)|Warning|Methods with variable arguments are not CLS-compliant|
|[CS3001](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3001)|Warning|Argument type '{0}' is not CLS-compliant|
|[CS3002](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3002)|Warning|Return type of '{0}' is not CLS-compliant|
|[CS3003](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs3003)|Warning|Type of '{0}' is not CLS-compliant|
|[CS3005](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3005)|Warning|Identifier '{0}' differing only in case is not CLS-compliant|
|[CS3006](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Warning|Overloaded method '{0}' differing only in ref or out, or in array rank, is not CLS-compliant|
|[CS3007](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Warning|Overloaded method '{0}' differing only by unnamed array types is not CLS-compliant|
|[CS3008](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3008)|Warning|Identifier '{0}' is not CLS-compliant|
|[CS3009](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs3009)|Warning|'{0}': base type '{1}' is not CLS-compliant|
|[CS3010](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3010)|Warning|'{0}': CLS-compliant interfaces must have only CLS-compliant members|
|[CS3011](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3011)|Warning|'{0}': only CLS-compliant members can be abstract|
|[CS3012](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3012)|Warning|You must specify the CLSCompliant attribute on the assembly, not the module, to enable CLS compliance checking|
|[CS3013](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3013)|Warning|Added modules must be marked with the CLSCompliant attribute to match the assembly|
|[CS3014](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3014)|Warning|'{0}' cannot be marked as CLS-compliant because the assembly does not have a CLSCompliant attribute|
|[CS3015](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3015)|Warning|'{0}' has no accessible constructors which use only CLS-compliant types|
|[CS3016](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Warning|Arrays as attribute arguments is not CLS-compliant|
|[CS3017](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3017)|Warning|You cannot specify the CLSCompliant attribute on a module that differs from the CLSCompliant attribute on the assembly|
|[CS3018](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3018)|Warning|'{0}' cannot be marked as CLS-compliant because it is a member of non-CLS-compliant type '{1}'|
|[CS3019](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3019)|Warning|CLS compliance checking will not be performed on '{0}' because it is not visible from outside this assembly|
|[CS3021](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3021)|Warning|'{0}' does not need a CLSCompliant attribute because the assembly does not have a CLSCompliant attribute|
|[CS3022](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3022)|Warning|CLSCompliant attribute has no meaning when applied to parameters. Try putting it on the method instead.|
|[CS3023](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3023)|Warning|CLSCompliant attribute has no meaning when applied to return types. Try putting it on the method instead.|
|[CS3024](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3024)|Warning|Constraint type '{0}' is not CLS-compliant|
|[CS3026](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3026)|Warning|CLS-compliant field '{0}' cannot be volatile|
|[CS3027](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3027)|Warning|'{0}' is not CLS-compliant because base interface '{1}' is not CLS-compliant|
|CS3028|Fatal|Algorithm '{0}' is not supported|
|CS4001|Error|Cannot await '{0}'|
|CS4003|Error|'await' cannot be used as an identifier within an async method or lambda expression|
|[CS4004](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4004)|Error|Cannot await in an unsafe context|
|CS4005|Error|Async methods cannot have pointer type parameters|
|CS4006|Error|\_\_arglist is not allowed in the parameter list of async methods|
|CS4007|Error|Instance of type '{0}' cannot be preserved across 'await' or 'yield' boundary.|
|[CS4008](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4008)|Error|Cannot await 'void'|
|[CS4009](https://docs.microsoft.com/en-us/dotnet/csharp/misc/CS4009)|Error|A void or int returning entry point cannot be async|
|CS4010|Error|Cannot convert async {0} to delegate type '{1}'. An async {0} may return void, Task or Task\<T\>, none of which are convertible to '{1}'.|
|CS4011|Error|'await' requires that the return type '{0}' of '{1}.GetAwaiter()' have suitable 'IsCompleted', 'OnCompleted', and 'GetResult' members, and implement 'INotifyCompletion' or 'ICriticalNotifyCompletion'|
|CS4012|Error|Parameters of type '{0}' cannot be declared in async methods or async lambda expressions.|
|[CS4013](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|Instance of type '{0}' cannot be used inside a nested function, query expression, iterator block or async method|
|[CS4014](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4014)|Warning|Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the 'await' operator to the result of the call.|
|CS4015|Error|'MethodImplOptions.Synchronized' cannot be applied to an async method|
|CS4016|Error|Since this is an async method, the return expression must be of type '{0}' rather than '{1}'|
|CS4017|Error|CallerLineNumberAttribute cannot be applied because there are no standard conversions from type '{0}' to type '{1}'|
|CS4018|Error|CallerFilePathAttribute cannot be applied because there are no standard conversions from type '{0}' to type '{1}'|
|CS4019|Error|CallerMemberNameAttribute cannot be applied because there are no standard conversions from type '{0}' to type '{1}'|
|CS4020|Error|The CallerLineNumberAttribute may only be applied to parameters with default values|
|CS4021|Error|The CallerFilePathAttribute may only be applied to parameters with default values|
|CS4022|Error|The CallerMemberNameAttribute may only be applied to parameters with default values|
|CS4023|Error|/platform:anycpu32bitpreferred can only be used with /t:exe, /t:winexe and /t:appcontainerexe|
|CS4024|Warning|The CallerLineNumberAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments|
|CS4025|Warning|The CallerFilePathAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments|
|CS4026|Warning|The CallerMemberNameAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments|
|CS4027|Error|'{0}' does not implement '{1}'|
|CS4028|Error|'await' requires that the type '{0}' have a suitable 'GetAwaiter' method. Are you missing a using directive for 'System'?|
|CS4029|Error|Cannot return an expression of type 'void'|
|CS4030|Error|Security attribute '{0}' cannot be applied to an Async method.|
|CS4031|Error|Async methods are not allowed in an Interface, Class, or Structure which has the 'SecurityCritical' or 'SecuritySafeCritical' attribute.|
|[CS4032](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4032)|Error|The 'await' operator can only be used within an async method. Consider marking this method with the 'async' modifier and changing its return type to 'Task\<{0}\>'.|
|[CS4033](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4033)|Error|The 'await' operator can only be used within an async method. Consider marking this method with the 'async' modifier and changing its return type to 'Task'.|
|CS4034|Error|The 'await' operator can only be used within an async {0}. Consider marking this {0} with the 'async' modifier.|
|CS4036|Error|'{0}' does not contain a definition for '{1}' and no extension method '{1}' accepting a first argument of type '{0}' could be found (are you missing a using directive for '{2}'?)|
|[CS5001](https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs5001)|Error|Program does not contain a static 'Main' method suitable for an entry point|
|[CS7000](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|Unexpected use of an aliased name|
|CS7002|Error|Unexpected use of a generic name|
|[CS7003](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs7003)|Error|Unexpected use of an unbound generic name|
|CS7006|Error|Expressions and statements can only occur in a method body|
|[CS7007](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|A 'using static' directive can only be applied to types; '{0}' is a namespace not a type. Consider a 'using namespace' directive instead|
|[CS7008](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The assembly name '{0}' is reserved and cannot be used as a reference in an interactive session|
|CS7009|Error|Cannot use #r after first token in file|
|CS7010|Error|Quoted file name expected|
|CS7011|Error|#r is only allowed in scripts|
|CS7012|Error|The name '{0}' does not exist in the current context (are you missing a reference to assembly '{1}'?)|
|CS7013|Error|Name '{0}' exceeds the maximum length allowed in metadata.|
|CS7014|Error|Attributes are not valid in this context.|
|CS7015|Error|'extern alias' is not valid in this context|
|CS7016|Error|Alias '{0}' conflicts with {1} definition|
|CS7017|Error|Member definition, statement, or end-of-file expected|
|CS7018|Error|Expected a script (.csx file) but none specified|
|CS7019|Error|Type of '{0}' cannot be inferred since its initializer directly or indirectly refers to the definition.|
|CS7020|Error|Cannot use 'yield' in top-level script code|
|CS7021|Error|Cannot declare namespace in script code|
|CS7022|Warning|The entry point of the program is global code; ignoring '{0}' entry point.|
|[CS7023](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|The second operand of an 'is' or 'as' operator may not be static type '{0}'|
|CS7024|Error|Delegate '{0}' has no invoke method or an invoke method with a return type or parameter types that are not supported.|
|CS7025|Error|Inconsistent accessibility: event type '{1}' is less accessible than event '{0}'|
|CS7026|Error|Assembly and module attributes are not allowed in this context|
|CS7027|Error|Error signing output with public key from file '{0}' -- {1}|
|CS7028|Error|Error signing output with public key from container '{0}' -- {1}|
|CS7029|Error|Friend access was granted by '{0}', but the strong name signing state of the output assembly does not match that of the granting assembly.|
|CS7030|Error|Cannot pass null for friend assembly name|
|CS7032|Error|Key file '{0}' is missing the private key needed for signing|
|CS7033|Warning|Delay signing was specified and requires a public key, but no public key was specified|
|CS7034|Error|The specified version string '{0}' does not conform to the required format - major[.minor[.build[.revision]]]|
|CS7035|Warning|The specified version string '{0}' does not conform to the recommended format - major.minor.build.revision|
|[CS7036](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|There is no argument given that corresponds to the required parameter '{0}' of '{1}'|
|CS7038|Error|Failed to emit module '{0}': {1}|
|CS7041|Error|Each linked resource and module must have a unique filename. Filename '{0}' is specified more than once in this assembly|
|CS7042|Error|The DllImport attribute cannot be applied to a method that is generic or contained in a generic method or type.|
|CS7043|Error|Cannot emit update; {0} '{1}' is missing.|
|CS7045|Error|Parameter not valid for the specified unmanaged type.|
|CS7046|Error|Attribute parameter '{0}' must be specified.|
|CS7047|Error|Attribute parameter '{0}' or '{1}' must be specified.|
|CS7048|Error|First argument to a security attribute must be a valid SecurityAction|
|CS7049|Error|Security attribute '{0}' has an invalid SecurityAction value '{1}'|
|CS7050|Error|SecurityAction value '{0}' is invalid for security attributes applied to an assembly|
|CS7051|Error|SecurityAction value '{0}' is invalid for security attributes applied to a type or a method|
|CS7052|Error|SecurityAction value '{0}' is invalid for PrincipalPermission attribute|
|[CS7053](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain '{0}'|
|CS7054|Error|Unmanaged type '{0}' not valid for fields.|
|CS7055|Error|Unmanaged type '{0}' is only valid for fields.|
|CS7056|Error|Unable to resolve file path '{0}' specified for the named argument '{1}' for PermissionSet attribute|
|CS7057|Error|Error reading file '{0}' specified for the named argument '{1}' for PermissionSet attribute: '{2}'|
|CS7058|Error|The specified version string '{0}' does not conform to the required format - major.minor.build.revision (without wildcards)|
|CS7059|Error|Executables cannot be satellite assemblies; culture should always be empty|
|CS7061|Error|Duplicate '{0}' attribute in '{1}'|
|CS7064|Error|Error opening icon file {0} -- {1}|
|CS7065|Error|Error building Win32 resources -- {0}|
|[CS7067](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Attribute constructor parameter '{0}' is optional, but no default parameter value was specified.|
|[CS7068](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|Reference to type '{0}' claims it is defined in this assembly, but it is not defined in source or any added modules|
|[CS7069](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|Reference to type '{0}' claims it is defined in '{1}', but it could not be found|
|CS7070|Error|Security attribute '{0}' is not valid on this declaration type. Security attributes are only valid on assembly, type and method declarations.|
|[CS7071](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|Assembly reference '{0}' is invalid and cannot be resolved|
|[CS7079](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|The type '{0}' is defined in a module that has not been added. You must add the module '{1}'.|
|CS7080|Warning|The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerFilePathAttribute.|
|CS7081|Warning|The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.|
|CS7082|Warning|The CallerFilePathAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.|
|CS7083|Error|Expression must be implicitly convertible to Boolean or its type '{0}' must define operator '{1}'.|
|[CS7084](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|A Windows Runtime event may not be passed as an out or ref parameter.|
|CS7086|Error|Module name '{0}' stored in '{1}' must match its filename.|
|CS7087|Error|Invalid module name: {0}|
|CS7088|Error|Invalid '{0}' value: '{1}'.|
|CS7089|Error|AppConfigPath must be absolute.|
|CS7090|Warning|Attribute '{0}' from module '{1}' will be ignored in favor of the instance appearing in source|
|CS7091|Error|Attribute '{0}' given in a source file conflicts with option '{1}'.|
|CS7092|Error|A fixed buffer may only have one dimension.|
|CS7093|Error|Cannot read config file '{0}' -- '{1}'|
|CS7094|Error|Cannot await in the filter expression of a catch clause|
|CS7095|Warning|Filter expression is a constant 'true', consider removing the filter|
|CS7096|Error|Cannot continue since the edit includes a reference to an embedded type: '{0}'.|
|CS7098|Error|Linked netmodule metadata must provide a full PE image: '{0}'.|
|CS7099|Error|Metadata references are not supported.|
|CS7100|Error|Assembly culture strings may not contain embedded NUL characters.|
|CS7101|Error|Member '{0}' added during the current debug session can only be accessed from within its declaring assembly '{1}'.|
|CS7102|Error|Compilation options '{0}' and '{1}' can't both be specified at the same time.|
|CS7103|Error|Unable to read debug information of method '{0}' (token 0x{1:X8}) from assembly '{2}': {3}|
|CS8001|Warning|The command line switch '{0}' is not yet implemented and was ignored.|
|CS8002|Warning|Referenced assembly '{0}' does not have a strong name.|
|CS8003|Error|Invalid signature public key specified in AssemblySignatureKeyAttribute.|
|CS8004|Error|Type '{0}' exported from module '{1}' conflicts with type declared in primary module of this assembly.|
|CS8005|Error|Type '{0}' exported from module '{1}' conflicts with type '{2}' exported from module '{3}'.|
|CS8006|Error|Forwarded type '{0}' conflicts with type declared in primary module of this assembly.|
|CS8007|Error|Type '{0}' forwarded to assembly '{1}' conflicts with type '{2}' forwarded to assembly '{3}'.|
|CS8008|Error|Type '{0}' forwarded to assembly '{1}' conflicts with type '{2}' exported from module '{3}'.|
|CS8009|Warning|Referenced assembly '{0}' has different culture setting of '{1}'.|
|CS8010|Error|Agnostic assembly cannot have a processor specific module '{0}'.|
|CS8011|Error|Assembly and module '{0}' cannot target different processors.|
|CS8012|Warning|Referenced assembly '{0}' targets a different processor.|
|CS8013|Error|Cryptographic failure while creating hashes.|
|CS8014|Error|Reference to '{0}' netmodule missing.|
|CS8015|Error|Module '{0}' is already defined in this assembly. Each module must have a unique filename.|
|CS8016|Error|Transparent identifier member access failed for field '{0}' of '{1}'.  Does the data being queried implement the query pattern?|
|CS8017|Error|The parameter has multiple distinct default values.|
|CS8018|Warning|Within cref attributes, nested types of generic types should be qualified.|
|[CS8019](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Hidden|Unnecessary using directive.|
|CS8020|Hidden|Unused extern alias.|
|CS8021|Warning|No value for RuntimeMetadataVersion found. No assembly containing System.Object was found nor was a value for RuntimeMetadataVersion specified through options.|
|[CS8022](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 1. Please use language version {1} or greater.|
|[CS8023](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 2. Please use language version {1} or greater.|
|[CS8024](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 3. Please use language version {1} or greater.|
|[CS8025](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 4. Please use language version {1} or greater.|
|[CS8026](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 5. Please use language version {1} or greater.|
|CS8027|Error|The field has multiple distinct constant values.|
|CS8028|Error|'{0}': a class with the ComImport attribute cannot specify field initializers.|
|CS8029|Warning|Local name '{0}' is too long for PDB.  Consider shortening or compiling without /debug.|
|[CS8030](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Anonymous function converted to a void returning delegate cannot return a value|
|CS8031|Error|Async lambda expression converted to a '{0}' returning delegate cannot return a value|
|CS8032|Warning|An instance of analyzer {0} cannot be created from {1} : {2}.|
|CS8033|Warning|The assembly {0} does not contain any analyzers.|
|CS8034|Warning|Unable to load Analyzer assembly {0} : {1}|
|CS8035|Error|Error reading ruleset file {0} - {1}|
|CS8036|Error|Error reading debug information for '{0}'|
|CS8040|Info|Skipping some types in analyzer assembly {0} due to a ReflectionTypeLoadException : {1}.|
|CS8050|Error|Only auto-implemented properties, or properties that use the 'field' keyword, can have initializers.|
|CS8051|Error|Auto-implemented properties must have get accessors.|
|CS8053|Error|Instance properties in interfaces cannot have initializers.|
|[CS8054](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Enums cannot contain explicit parameterless constructors|
|CS8055|Error|Cannot emit debug information for a source text without encoding.|
|CS8057|Error|Block bodies and expression bodies cannot both be provided.|
|[CS8058](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is experimental and unsupported; use '/features:{1}' to enable.|
|[CS8059](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 6. Please use language version {1} or greater.|
|CS8070|Error|Control cannot fall out of switch from final case label ('{0}')|
|[CS8072](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree lambda may not contain a null propagating operator.|
|[CS8073](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|The result of the expression is always '{0}' since a value of type '{1}' is never equal to 'null' of type '{2}'|
|[CS8074](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree lambda may not contain a dictionary initializer.|
|[CS8075](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An extension Add method is not supported for a collection initializer in an expression lambda.|
|CS8076|Error|Missing close delimiter '}' for interpolated expression started with '{'.|
|CS8078|Error|An expression is too long or complex to compile|
|CS8079|Error|Use of possibly unassigned auto-implemented property '{0}'|
|CS8080|Error|Auto-implemented properties must override all accessors of the overridden property.|
|CS8081|Error|Expression does not have a name.|
|CS8082|Error|Sub-expression cannot be used in an argument to nameof.|
|[CS8083](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|An alias-qualified name is not an expression.|
|CS8084|Error|Type parameters are not allowed on a method group as an argument to 'nameof'.|
|[CS8085](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|A 'using static' directive cannot be used to declare an alias|
|CS8086|Error|A '{0}' character must be escaped (by doubling) in an interpolated string.|
|CS8087|Error|A '{0}' character may only be escaped by doubling '{0}{0}' in an interpolated string.|
|CS8088|Error|A format specifier may not contain trailing whitespace.|
|CS8089|Error|Empty format specifier.|
|[CS8090](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|There is an error in a referenced assembly '{0}'.|
|[CS8091](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|'{0}' cannot be extern and have a constructor initializer|
|CS8092|Error|Expression or declaration statement expected.|
|CS8093|Error|Extension method groups are not allowed as an argument to 'nameof'.|
|CS8094|Warning|Alignment value {0} has a magnitude greater than {1} and may result in a large formatted string.|
|CS8095|Error|Length of String constant resulting from concatenation exceeds System.Int32.MaxValue.  Try splitting the string into multiple constants.|
|CS8096|Error|Debug entry point must be a definition of a method declared in the current compilation.|
|CS8097|Error|#load is only allowed in scripts|
|CS8098|Error|Cannot use #load after first token in file|
|CS8099|Error|Source file references are not supported.|
|CS8100|Error|The 'await' operator cannot be used in a static script variable initializer.|
|CS8101|Error|The pathmap option was incorrectly formatted.|
|CS8102|Error|Public signing was specified and requires a public key, but no public key was specified.|
|CS8103|Error|Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals or try the EXPERIMENTAL feature flag 'experimental-data-section-string-literals'.|
|CS8104|Error|An error occurred while writing the output file: {0}.|
|CS8105|Warning|Attribute '{0}' is ignored when public signing is specified.|
|CS8106|Error|Option '{0}' must be an absolute path.|
|[CS8107](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 7.0. Please use language version {1} or greater.|
|CS8108|Error|Cannot pass argument with dynamic type to params parameter '{0}' of local function '{1}'.|
|[CS8110](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a reference to a local function|
|CS8111|Error|Invalid instrumentation kind: {0}|
|CS8112|Error|Local function '{0}' must declare a body because it is not marked 'static extern'.|
|CS8113|Error|Invalid hash algorithm name: '{0}'|
|CS8115|Error|A throw expression is not allowed in this context.|
|CS8116|Error|It is not legal to use nullable type '{0}?' in a pattern; use the underlying type '{0}' instead.|
|CS8117|Error|Invalid operand for pattern match; value required, but found '{0}'.|
|CS8119|Error|The switch expression must be a value; found '{0}'.|
|CS8120|Error|The switch case is unreachable. It has already been handled by a previous case or it is impossible to match.|
|CS8121|Error|An expression of type '{0}' cannot be handled by a pattern of type '{1}'.|
|[CS8122](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an 'is' pattern-matching operator.|
|CS8123|Warning|The tuple element name '{0}' is ignored because a different name or no name is specified by the target type '{1}'.|
|[CS8124](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8124)|Error|Tuple must contain at least two elements.|
|[CS8125](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8125)|Error|Tuple element name '{0}' is only allowed at position {1}.|
|CS8126|Error|Tuple element name '{0}' is disallowed at any position.|
|[CS8127](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8127)|Error|Tuple element names must be unique.|
|CS8128|Error|Member '{0}' was not found on type '{1}' from assembly '{2}'.|
|[CS8129](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8129)|Error|No suitable 'Deconstruct' instance or extension method was found for type '{0}', with {1} out parameters and a void return type.|
|[CS8130](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8130)|Error|Cannot infer the type of implicitly-typed deconstruction variable '{0}'.|
|[CS8131](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8131)|Error|Deconstruct assignment requires an expression with a type on the right-hand-side.|
|[CS8132](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8132)|Error|Cannot deconstruct a tuple of '{0}' elements into '{1}' variables.|
|CS8133|Error|Cannot deconstruct dynamic objects.|
|CS8134|Error|Deconstruction must contain at least two variables.|
|CS8135|Error|Tuple with {0} elements cannot be converted to type '{1}'.|
|CS8136|Error|Deconstruction 'var (...)' form disallows a specific type for 'var'.|
|CS8137|Error|Cannot define a class or member that utilizes tuples because the compiler required type '{0}' cannot be found. Are you missing a reference?|
|CS8138|Error|Cannot reference 'System.Runtime.CompilerServices.TupleElementNamesAttribute' explicitly. Use the tuple syntax to define tuple names.|
|[CS8139](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8139)|Error|'{0}': cannot change tuple element names when overriding inherited member '{1}'|
|[CS8140](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8140)|Error|'{0}' is already listed in the interface list on type '{2}' with different tuple element names, as '{1}'.|
|[CS8141](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8141)|Error|The tuple element names in the signature of method '{0}' must match the tuple element names of interface method '{1}' (including on the return type).|
|[CS8142](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial member declarations, '{0}' and '{1}', must use the same tuple element names.|
|[CS8143](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a tuple literal.|
|[CS8144](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a tuple conversion.|
|[CS8145](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8145)|Error|Auto-implemented properties cannot return by reference|
|[CS8146](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8146)|Error|Properties which return by reference must have a get accessor|
|[CS8147](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8147)|Error|Properties which return by reference cannot have set accessors|
|[CS8148](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8148)|Error|'{0}' must match by reference return of overridden member '{1}'|
|[CS8149](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8149)|Error|By-reference returns may only be used in methods that return by reference|
|[CS8150](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8150)|Error|By-value returns may only be used in methods that return by value|
|[CS8151](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8151)|Error|The return expression must be of type '{0}' because this method returns by reference|
|[CS8152](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8152)|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because it does not have matching return by reference.|
|[CS8153](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree lambda may not contain a call to a method, property, or indexer that returns by reference|
|[CS8154](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|The body of '{0}' cannot be an iterator block because '{0}' returns by reference|
|[CS8155](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|Lambda expressions that return by reference cannot be converted to expression trees|
|[CS8156](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8156)|Error|An expression cannot be used in this context because it may not be passed or returned by reference|
|[CS8157](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8157)|Error|Cannot return '{0}' by reference because it was initialized to a value that cannot be returned by reference|
|[CS8158](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8158)|Error|Cannot return by reference a member of '{0}' because it was initialized to a value that cannot be returned by reference|
|[CS8159](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8159)|Error|Cannot return the range variable '{0}' by reference|
|[CS8160](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8160)|Error|A readonly field cannot be returned by writable reference|
|[CS8161](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8161)|Error|A static readonly field cannot be returned by writable reference|
|[CS8162](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8162)|Error|Members of readonly field '{0}' cannot be returned by writable reference|
|[CS8163](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8163)|Error|Fields of static readonly field '{0}' cannot be returned by writable reference|
|[CS8166](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot return a parameter by reference '{0}' because it is not a ref parameter|
|[CS8167](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot return by reference a member of parameter '{0}' because it is not a ref or out parameter|
|[CS8168](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot return local '{0}' by reference because it is not a ref local|
|[CS8169](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot return a member of local '{0}' by reference because it is not a ref local|
|[CS8170](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8170)|Error|Struct members cannot return 'this' or other instance members by reference|
|[CS8171](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8171)|Error|Cannot initialize a by-value variable with a reference|
|[CS8172](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8172)|Error|Cannot initialize a by-reference variable with a value|
|[CS8173](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8173)|Error|The expression must be of type '{0}' because it is being assigned by reference|
|[CS8174](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8174)|Error|A declaration of a by-reference variable must have an initializer|
|[CS8175](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Cannot use ref local '{0}' inside an anonymous method, lambda expression, or query expression|
|[CS8178](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8178)|Error|A reference returned by a call to '{0}' cannot be preserved across 'await' or 'yield' boundary.|
|CS8179|Error|Predefined type '{0}' is not defined or imported|
|CS8180|Error|{ or ; or =\> expected|
|CS8181|Error|'new' cannot be used with tuple type. Use a tuple literal expression instead.|
|CS8182|Error|Predefined type '{0}' must be a struct.|
|CS8183|Error|Cannot infer the type of implicitly-typed discard.|
|CS8185|Error|A declaration is not allowed in this context.|
|CS8186|Error|A foreach loop must declare its iteration variables.|
|CS8187|Error|Tuple element names are not permitted on the left of a deconstruction.|
|CS8188|Error|An expression tree may not contain a throw-expression.|
|CS8189|Error|Ref mismatch between '{0}' and delegate '{1}'|
|CS8190|Error|Provided source code kind is unsupported or invalid: '{0}'|
|CS8191|Error|Provided documentation mode is unsupported or invalid: '{0}'.|
|[CS8192](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Provided language version is unsupported or invalid: '{0}'.|
|[CS8196](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Reference to an implicitly-typed out variable '{0}' is not permitted in the same argument list.|
|CS8197|Error|Cannot infer the type of implicitly-typed out variable '{0}'.|
|[CS8198](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an out argument variable declaration.|
|CS8199|Error|The syntax 'var (...)' as an lvalue is reserved.|
|CS8202|Error|Public signing is not supported for netmodules.|
|[CS8203](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/assembly-references)|Error|Invalid assembly name: {0}|
|CS8204|Error|For type '{0}' to be used as an AsyncMethodBuilder for type '{1}', its Task property should return type '{1}' instead of type '{2}'.|
|CS8206|Error|Module '{0}' in assembly '{1}' is forwarding the type '{2}' to multiple assemblies: '{3}' and '{4}'.|
|[CS8207](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a discard.|
|CS8208|Error|It is not legal to use the type 'dynamic' in a pattern.|
|CS8209|Error|A value of type 'void' may not be assigned.|
|[CS8210](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8210)|Error|A tuple may not contain a value of type 'void'.|
|CS8300|Error|Merge conflict marker encountered|
|CS8301|Error|Invalid name for a preprocessing symbol; '{0}' is not a valid identifier|
|[CS8302](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 7.1. Please use language version {1} or greater.|
|[CS8303](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Specified language version '{0}' cannot have leading zeroes|
|[CS8304](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Compiler version: '{0}'. Language version: {1}.|
|[CS8305](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Warning|'{0}' is for evaluation purposes only and is subject to change or removal in future updates.|
|[CS8306](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Tuple element name '{0}' is inferred. Please use language version {1} or greater to access an element by its inferred name.|
|CS8307|Error|The first operand of an 'as' operator may not be a tuple literal without a natural type.|
|CS8308|Error|Do not use refout when using refonly.|
|CS8309|Error|Cannot compile net modules when using /refout or /refonly.|
|CS8310|Error|Operator '{0}' cannot be applied to operand '{1}'|
|CS8312|Error|Use of default literal is not valid in this context|
|[CS8314](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|An expression of type '{0}' cannot be handled by a pattern of type '{1}' in C# {2}. Please use language version {3} or greater.|
|[CS8315](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Operator '{0}' is ambiguous on operands '{1}' and '{2}'|
|[CS8320](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 7.2. Please use language version {1} or greater.|
|CS8321|Warning|The local function '{0}' is declared but never used|
|CS8322|Error|Cannot pass argument with dynamic type to generic local function '{0}' with inferred type arguments.|
|CS8323|Error|Named argument '{0}' is used out-of-position but is followed by an unnamed argument|
|[CS8324](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Named argument specifications must appear after all fixed arguments have been specified in a dynamic invocation.|
|CS8325|Error|'await' cannot be used in an expression containing a ref conditional operator|
|[CS8326](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Both conditional operator values must be ref values or neither may be a ref value|
|[CS8327](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|The expression must be of type '{0}' to match the alternative ref value|
|CS8328|Error| The parameter modifier '{0}' cannot be used with '{1}'|
|[CS8329](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot use {0} '{1}' as a ref or out value because it is a readonly variable|
|[CS8330](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Members of {0} '{1}' cannot be used as a ref or out value because it is a readonly variable|
|[CS8331](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot assign to {0} '{1}' or use it as the right hand side of a ref assignment because it is a readonly variable|
|[CS8332](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot assign to a member of {0} '{1}' or use it as the right hand side of a ref assignment because it is a readonly variable|
|[CS8333](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8333)|Error|Cannot return {0} '{1}' by writable reference because it is a readonly variable|
|[CS8334](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8334)|Error|Members of {0} '{1}' cannot be returned by writable reference because it is a readonly variable|
|CS8335|Error|Do not use '{0}'. This is reserved for compiler usage.|
|CS8336|Error|The type name '{0}' is reserved to be used by the compiler.|
|[CS8337](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|The first parameter of a 'ref' extension method '{0}' must be a value type or a generic type constrained to struct.|
|[CS8338](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|The first 'in' or 'ref readonly' parameter of the extension method '{0}' must be a concrete (non-generic) value type.|
|CS8340|Error|Instance fields of readonly structs must be readonly.|
|CS8341|Error|Auto-implemented instance properties in readonly structs must be readonly.|
|CS8342|Error|Field-like events are not allowed in readonly structs.|
|[CS8345](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|Field or auto-implemented property cannot be of type '{0}' unless it is an instance member of a ref struct.|
|CS8346|Error|Conversion of a stackalloc expression of type '{0}' to type '{1}' is not possible.|
|CS8347|Error|Cannot use a result of '{0}' in this context because it may expose variables referenced by parameter '{1}' outside of their declaration scope|
|CS8348|Error|Cannot use a member of result of '{0}' in this context because it may expose variables referenced by parameter '{1}' outside of their declaration scope|
|CS8349|Error|Expression cannot be used in this context because it may indirectly expose variables outside of their declaration scope|
|CS8350|Error|This combination of arguments to '{0}' is disallowed because it may expose variables referenced by parameter '{1}' outside of their declaration scope|
|[CS8351](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Branches of a ref conditional operator cannot refer to variables with incompatible declaration scopes|
|[CS8352](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8352)|Error|Cannot use variable '{0}' in this context because it may expose referenced variables outside of their declaration scope|
|CS8353|Error|A result of a stackalloc expression of type '{0}' cannot be used in this context because it may be exposed outside of the containing method|
|[CS8354](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8354)|Error|Cannot return 'this' by reference.|
|[CS8355](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8355)|Error|An in parameter cannot have the Out attribute.|
|CS8356|Error|Predefined type '{0}' is declared in multiple referenced assemblies: '{1}' and '{2}'|
|CS8357|Error|The specified version string '{0}' contains wildcards, which are not compatible with determinism. Either remove wildcards from the version string, or disable determinism for this compilation|
|[CS8358](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Cannot use attribute constructor '{0}' because it has 'in' or 'ref readonly' parameters.|
|CS8359|Warning|Filter expression is a constant 'false', consider removing the catch clause|
|CS8360|Warning|Filter expression is a constant 'false', consider removing the try-catch block|
|CS8361|Error|A conditional expression cannot be used directly in a string interpolation because the ':' ends the interpolation. Parenthesize the conditional expression.|
|CS8362|Error|\_\_arglist cannot have an argument of void type|
|CS8364|Error|Arguments with 'in' modifier cannot be used in dynamically dispatched expressions.|
|[CS8370](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 7.3. Please use language version {1} or greater.|
|[CS8371](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Warning|Field-targeted attributes on auto-properties are not supported in language version {0}. Please use language version {1} or greater.|
|CS8372|Error|Do not use 'System.Runtime.CompilerServices.FixedBuffer' attribute on a property|
|[CS8373](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|The left-hand side of a ref assignment must be a ref variable.|
|[CS8374](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot ref-assign '{1}' to '{0}' because '{1}' has a narrower escape scope than '{0}'.|
|CS8375|Error|The 'new()' constraint cannot be used with the 'unmanaged' constraint|
|CS8377|Error|The type '{2}' must be a non-nullable value type, along with all fields at any level of nesting, in order to use it as parameter '{1}' in the generic type or method '{0}'|
|CS8378|Error|\_\_arglist cannot have an argument passed by 'in' or 'out'|
|CS8379|Error|Type parameter '{1}' has the 'unmanaged' constraint so '{1}' cannot be used as a constraint for '{0}'|
|CS8380|Error|'{0}': cannot specify both a constraint class and the 'unmanaged' constraint|
|CS8381|Error|"Invalid rank specifier: expected ']'|
|[CS8382](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a tuple == or != operator|
|CS8383|Warning|The tuple element name '{0}' is ignored because a different name or no name is specified on the other side of the tuple == or != operator.|
|CS8384|Error|Tuple types used as operands of an == or != operator must have matching cardinalities. But this operator has tuple types of cardinality {0} on the left and {1} on the right.|
|CS8385|Error|The given expression cannot be used in a fixed statement|
|CS8386|Error|Invalid object creation|
|CS8387|Warning|Type parameter '{0}' has the same name as the type parameter from outer method '{1}'|
|[CS8388](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|An out variable cannot be declared as a ref local|
|CS8389|Error|Omitting the type argument is not allowed in the current context|
|[CS8400](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 8.0. Please use language version {1} or greater.|
|[CS8401](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|To use '@$' instead of '$@' for an interpolated verbatim string, please use language version '{0}' or greater.|
|[CS8403](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8403)|Error|Method '{0}' with an iterator block must be 'async' to return '{1}'|
|[CS8410](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8410)|Error|'{0}': type used in an asynchronous using statement must implement 'System.IAsyncDisposable' or implement a suitable 'DisposeAsync' method.|
|[CS8411](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8411)|Error|Asynchronous foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a suitable public instance or extension definition for '{1}'|
|CS8412|Error|Asynchronous foreach requires that the return type '{0}' of '{1}' must have a suitable public 'MoveNextAsync' method and public 'Current' property|
|CS8413|Error|Asynchronous foreach statement cannot operate on variables of type '{0}' because it implements multiple instantiations of '{1}'; try casting to a specific interface instantiation|
|CS8414|Error|foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'. Did you mean 'await foreach' rather than 'foreach'?|
|CS8415|Error|Asynchronous foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'. Did you mean 'foreach' rather than 'await foreach'?|
|CS8416|Error|Cannot use a collection of dynamic type in an asynchronous foreach|
|CS8417|Error|'{0}': type used in an asynchronous using statement must implement 'System.IAsyncDisposable' or implement a suitable 'DisposeAsync' method. Did you mean 'using' rather than 'await using'?|
|CS8418|Error|'{0}': type used in a using statement must implement 'System.IDisposable'. Did you mean 'await using' rather than 'using'?|
|CS8419|Error|The body of an async-iterator method must contain a 'yield' statement.|
|CS8420|Error|The body of an async-iterator method must contain a 'yield' statement. Consider removing 'async' from the method declaration or adding a 'yield' statement.|
|CS8421|Error|A static local function cannot contain a reference to '{0}'.|
|[CS8422](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8422)|Error|A static local function cannot contain a reference to 'this' or 'base'.|
|CS8423|Error|Attribute '{0}' is not valid on event accessors. It is only valid on '{1}' declarations.|
|CS8424|Warning|The EnumeratorCancellationAttribute applied to parameter '{0}' will have no effect. The attribute is only effective on a parameter of type CancellationToken in an async-iterator method returning IAsyncEnumerable|
|CS8425|Warning|Async-iterator '{0}' has one or more parameters of type 'CancellationToken' but none of them is decorated with the 'EnumeratorCancellation' attribute, so the cancellation token parameter from the generated 'IAsyncEnumerable\<\>.GetAsyncEnumerator' will be unconsumed|
|CS8426|Error|The attribute [EnumeratorCancellation] cannot be used on multiple parameters|
|CS8427|Error|Enums, classes, and structures cannot be declared in an interface that has an 'in' or 'out' type parameter.|
|CS8428|Error|Invocation of implicit Index Indexer cannot name the argument.|
|CS8429|Error|Invocation of implicit Range Indexer cannot name the argument.|
|CS8500|Warning|This takes the address of, gets the size of, or declares a pointer to a managed type ('{0}')|
|CS8502|Error|Matching the tuple type '{0}' requires '{1}' subpatterns, but '{2}' subpatterns are present.|
|CS8503|Error|A property subpattern requires a reference to the property or field to be matched, e.g. '{{ Name: {0} }}'|
|CS8504|Error|Pattern missing|
|CS8505|Error|A default literal 'default' is not valid as a pattern. Use another literal (e.g. '0' or 'null') as appropriate. To match everything, use a discard pattern '\_'.|
|CS8506|Error|No best type was found for the switch expression.|
|CS8508|Error|The syntax 'var' for a pattern is not permitted to refer to a type, but '{0}' is in scope here.|
|[CS8509](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/pattern-matching-warnings)|Warning|The switch expression does not handle all possible values of its input type (it is not exhaustive). For example, the pattern '{0}' is not covered.|
|CS8510|Error|The pattern is unreachable. It has already been handled by a previous arm of the switch expression or it is impossible to match.|
|[CS8511](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|An expression of type '{0}' cannot be handled by a pattern of type '{1}'. Please use language version '{2}' or greater to match an open type with a constant pattern.|
|CS8512|Warning|The name '\_' refers to the constant, not the discard pattern. Use 'var \_' to discard the value, or '@\_' to refer to a constant by that name.|
|CS8513|Warning|The name '\_' refers to the type '{0}', not the discard pattern. Use '@\_' for the type, or 'var \_' to discard.|
|[CS8514](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a switch expression.|
|[CS8515](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8515)|Error|Parentheses are required around the switch governing expression.|
|CS8516|Error|The name '{0}' does not identify tuple element '{1}'.|
|CS8517|Error|The name '{0}' does not match the corresponding 'Deconstruct' parameter '{1}'.|
|CS8518|Error|An expression of type '{0}' can never match the provided pattern.|
|CS8519|Warning|The given expression never matches the provided pattern.|
|CS8520|Warning|The given expression always matches the provided constant.|
|CS8521|Error|Pattern-matching is not permitted for pointer types.|
|CS8522|Error|Element names are not permitted when pattern-matching via 'System.Runtime.CompilerServices.ITuple'.|
|CS8523|Error|The discard pattern is not permitted as a case label in a switch statement. Use 'case var \_:' for a discard pattern, or 'case @\_:' for a constant named '\_'.|
|CS8524|Warning|The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value. For example, the pattern '{0}' is not covered.|
|[CS8597](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Thrown value may be null.|
|[CS8598](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Error|The suppression operator is not allowed in this context|
|[CS8600](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Converting null literal or possible null value to non-nullable type.|
|[CS8601](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Possible null reference assignment.|
|[CS8602](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Dereference of a possibly null reference.|
|CS8603|Warning|Possible null reference return.|
|[CS8604](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Possible null reference argument for parameter '{0}' in '{1}'.|
|[CS8605](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Unboxing a possibly null value.|
|[CS8607](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|A possible null value may not be used for a type marked with [NotNull] or [DisallowNull]|
|[CS8608](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type doesn't match overridden member.|
|[CS8609](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in return type doesn't match overridden member.|
|[CS8610](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type of parameter '{0}' doesn't match overridden member.|
|[CS8611](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type of parameter '{0}' doesn't match partial method declaration.|
|[CS8612](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type of '{0}' doesn't match implicitly implemented member '{1}'.|
|[CS8613](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in return type of '{0}' doesn't match implicitly implemented member '{1}'.|
|[CS8614](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type of parameter '{0}' of '{1}' doesn't match implicitly implemented member '{2}'.|
|[CS8615](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type doesn't match implemented member '{0}'.|
|[CS8616](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in return type doesn't match implemented member '{0}'.|
|[CS8617](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type of parameter '{0}' doesn't match implemented member '{1}'.|
|[CS8618](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Non-nullable {0} '{1}' must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring the {0} as nullable.|
|[CS8619](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in value of type '{0}' doesn't match target type '{1}'.|
|[CS8620](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Argument of type '{0}' cannot be used for parameter '{2}' of type '{1}' in '{3}' due to differences in the nullability of reference types.|
|[CS8621](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in return type of '{0}' doesn't match the target delegate '{1}' (possibly because of nullability attributes).|
|[CS8622](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type of parameter '{0}' of '{1}' doesn't match the target delegate '{2}' (possibly because of nullability attributes).|
|[CS8623](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Error|Explicit application of 'System.Runtime.CompilerServices.NullableAttribute' is not allowed.|
|[CS8624](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Argument of type '{0}' cannot be used as an output of type '{1}' for parameter '{2}' in '{3}' due to differences in the nullability of reference types.|
|[CS8625](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Cannot convert null literal to non-nullable reference type.|
|[CS8627](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|A nullable type parameter must be known to be a value type or non-nullable reference type unless language version '{0}' or greater is used. Consider changing the language version or adding a 'class', 'struct', or type constraint.|
|[CS8628](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Error|Cannot use a nullable reference type in object creation.|
|[CS8629](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullable value type may be null.|
|[CS8630](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Invalid '{0}' value: '{1}' for C# {2}. Please use language version '{3}' or greater.|
|[CS8631](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. Nullability of type argument '{3}' doesn't match constraint type '{1}'.|
|[CS8632](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.|
|[CS8633](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability in constraints for type parameter '{0}' of method '{1}' doesn't match the constraints for type parameter '{2}' of interface method '{3}'. Consider using an explicit interface implementation instead.|
|[CS8634](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|The type '{2}' cannot be used as type parameter '{1}' in the generic type or method '{0}'. Nullability of type argument '{2}' doesn't match 'class' constraint.|
|CS8635|Error|Unexpected character sequence '...'|
|[CS8636](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Error|Invalid option '{0}' for /nullable; must be 'disable', 'enable', 'warnings' or 'annotations'|
|[CS8637](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Error|Expected 'enable', 'disable', or 'restore'|
|[CS8639](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Error|The typeof operator cannot be used on a nullable reference type|
|[CS8640](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|Expression tree cannot contain value of ref struct or restricted type '{0}'.|
|CS8641|Error|'else' cannot start a statement.|
|[CS8642](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a null coalescing assignment|
|[CS8643](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in explicit interface specifier doesn't match interface implemented by the type.|
|[CS8644](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|'{0}' does not implement interface member '{1}'. Nullability of reference types in interface implemented by the base type doesn't match.|
|[CS8645](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|'{0}' is already listed in the interface list on type '{1}' with different nullability of reference types.|
|CS8646|Error|'{0}' is explicitly implemented more than once.|
|CS8647|Error|A using variable cannot be used directly within a switch section (consider using braces). |
|CS8648|Error|A goto cannot jump to a location after a using declaration.|
|CS8649|Error|A goto cannot jump to a location before a using declaration within the same block.|
|CS8650|Error|It is not legal to use nullable reference type '{0}?' in an is-type expression; use the underlying type '{0}' instead.|
|CS8651|Error|It is not legal to use nullable reference type '{0}?' in an as expression; use the underlying type '{0}' instead.|
|[CS8652](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|The feature '{0}' is currently in Preview and \*unsupported\*. To use Preview features, use the 'preview' language version.|
|[CS8655](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|The switch expression does not handle some null inputs (it is not exhaustive). For example, the pattern '{0}' is not covered.|
|CS8656|Warning|Call to non-readonly member '{0}' from a 'readonly' member results in an implicit copy of '{1}'.|
|CS8657|Error|Static member '{0}' cannot be marked 'readonly'.|
|CS8658|Error|Auto-implemented 'set' accessor '{0}' cannot be marked 'readonly'.|
|CS8659|Error|Auto-implemented property '{0}' cannot be marked 'readonly' because it has a 'set' accessor.|
|CS8660|Error|Cannot specify 'readonly' modifiers on both property or indexer '{0}' and its accessor. Remove one of them.|
|CS8661|Error|Cannot specify 'readonly' modifiers on both accessors of property or indexer '{0}'. Instead, put a 'readonly' modifier on the property itself.|
|CS8662|Error|Field-like event '{0}' cannot be 'readonly'.|
|[CS8663](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial member declarations must be readonly or neither may be readonly|
|CS8664|Error|'{0}': 'readonly' can only be used on accessors if the property or indexer has both a get and a set accessor|
|CS8665|Error|Method '{0}' specifies a 'class' constraint for type parameter '{1}', but corresponding type parameter '{2}' of overridden or explicitly implemented method '{3}' is not a reference type.|
|CS8666|Error|Method '{0}' specifies a 'struct' constraint for type parameter '{1}', but corresponding type parameter '{2}' of overridden or explicitly implemented method '{3}' is not a non-nullable value type.|
|[CS8667](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Partial method declarations of '{0}' have inconsistent nullability in constraints for type parameter '{1}'|
|CS8668|Error|Expected 'warnings', 'annotations', or end of directive|
|CS8669|Warning|The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.|
|[CS8670](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Object or collection initializer implicitly dereferences possibly null member '{0}'.|
|CS8700|Error|Multiple analyzer config files cannot be in the same directory ('{0}').|
|CS8701|Error|Target runtime doesn't support default interface implementation.|
|CS8702|Error|'{0}' cannot implement interface member '{1}' in type '{2}' because the target runtime doesn't support default interface implementation.|
|[CS8703](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|The modifier '{0}' is not valid for this item in C# {1}. Please use language version '{2}' or greater.|
|[CS8704](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implicitly implement a non-public member in C# {3}. Please use language version '{4}' or greater.|
|CS8705|Error|Interface member '{0}' does not have a most specific implementation. Neither '{1}', nor '{2}' are most specific.|
|[CS8706](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|'{0}' cannot implement interface member '{1}' in type '{2}' because feature '{3}' is not available in C# {4}. Please use language version '{5}' or greater.|
|CS8707|Error|Target runtime doesn't support 'protected', 'protected internal', or 'private protected' accessibility for a member of an interface.|
|CS8711|Error|Type '{0}' cannot be embedded because it has a non-abstract member. Consider setting the 'Embed Interop Types' property to false.|
|CS8712|Error|'{0}': abstract event cannot use event accessor syntax|
|[CS8714](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|The type '{2}' cannot be used as type parameter '{1}' in the generic type or method '{0}'. Nullability of type argument '{2}' doesn't match 'notnull' constraint.|
|CS8715|Error|Duplicate null suppression operator ('!')|
|CS8716|Error|There is no target type for the default literal.|
|CS8750|Error|Type '{0}' cannot be embedded because it has a re-abstraction of a member from base interface. Consider setting the 'Embed Interop Types' property to false.|
|CS8751|Error|Internal error in the C# compiler.|
|CS8752|Error|The type '{0}' may not be used as the target type of new()|
|CS8753|Error|Use of new() is not valid in this context|
|CS8754|Error|There is no target type for '{0}'|
|CS8755|Error|'{0}' cannot be used as a modifier on a function pointer parameter.|
|CS8756|Error|Function pointer '{0}' does not take {1} arguments|
|CS8757|Error|No overload for '{0}' matches function pointer '{1}'|
|CS8758|Error|Ref mismatch between '{0}' and function pointer '{1}'|
|CS8759|Error|Cannot create a function pointer for '{0}' because it is not a static method|
|CS8760|Error|'{0}': extern event cannot have initializer|
|CS8761|Error|Operator '{0}' cannot be applied to 'default' and operand of type '{1}' because it is a type parameter that is not known to be a reference type|
|[CS8762](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Parameter '{0}' must have a non-null value when exiting with '{1}'.|
|[CS8763](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|A method marked [DoesNotReturn] should not return.|
|[CS8764](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of return type doesn't match overridden member (possibly because of nullability attributes).|
|[CS8765](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of type of parameter '{0}' doesn't match overridden member (possibly because of nullability attributes).|
|[CS8766](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in return type of '{0}' doesn't match implicitly implemented member '{1}' (possibly because of nullability attributes).|
|[CS8767](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type of parameter '{0}' of '{1}' doesn't match implicitly implemented member '{2}' (possibly because of nullability attributes).|
|[CS8768](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in return type doesn't match implemented member '{0}' (possibly because of nullability attributes).|
|[CS8769](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in type of parameter '{0}' doesn't match implemented member '{1}' (possibly because of nullability attributes).|
|[CS8770](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Method '{0}' lacks `[DoesNotReturn]` annotation to match implemented or overridden member.|
|CS8771|Error|Output directory could not be determined|
|CS8772|Error|stdin argument '-' is specified, but input has not been redirected from the standard input stream.|
|[CS8773](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 9.0. Please use language version {1} or greater.|
|[CS8774](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Member '{0}' must have a non-null value when exiting.|
|[CS8775](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Member '{0}' must have a non-null value when exiting with '{1}'.|
|[CS8776](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Member '{0}' cannot be used in this attribute.|
|[CS8777](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Parameter '{0}' must have a non-null value when exiting.|
|CS8778|Warning|Constant value '{0}' may overflow '{1}' at runtime (use 'unchecked' syntax to override)|
|CS8779|Error|'{0}' is already listed in the interface list on type '{2}' as '{1}'.|
|CS8780|Error|A variable may not be declared within a 'not' or 'or' pattern.|
|CS8781|Error|Relational patterns may not be used for a value of type '{0}'.|
|CS8782|Error|Relational patterns may not be used for a floating-point NaN.|
|CS8783|Error|Local function '{0}' must be 'static' in order to use the Conditional attribute|
|CS8784|Warning|Generator '{0}' failed to initialize. It will not contribute to the output and compilation errors may occur as a result. Exception was of type '{1}' with message '{2}'.
{3}|
|CS8785|Warning|Generator '{0}' failed to generate source. It will not contribute to the output and compilation errors may occur as a result. Exception was of type '{1}' with message '{2}'.
{3}|
|CS8786|Error|Calling convention of '{0}' is not compatible with '{1}'.|
|CS8787|Error|Cannot convert method group to function pointer (Are you missing a '&'?)|
|CS8788|Error|Cannot use an extension method with a receiver as the target of a '&' operator.|
|CS8789|Error|The type of a local declared in a fixed statement cannot be a function pointer type.|
|[CS8790](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a pattern System.Index or System.Range indexer access|
|[CS8791](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a from-end index ('^') expression.|
|[CS8792](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a range ('..') expression.|
|CS8793|Warning|The given expression always matches the provided pattern.|
|CS8794|Warning|An expression of type '{0}' always matches the provided pattern.|
|[CS8795](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial method '{0}' must have an implementation part because it has accessibility modifiers.|
|[CS8796](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial method '{0}' must have accessibility modifiers because it has a non-void return type.|
|[CS8797](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial method '{0}' must have accessibility modifiers because it has 'out' parameters.|
|[CS8798](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial method '{0}' must have accessibility modifiers because it has a 'virtual', 'override', 'sealed', 'new', or 'extern' modifier.|
|[CS8799](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial member declarations must have identical accessibility modifiers.|
|[CS8800](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial member declarations must have identical combinations of 'virtual', 'override', 'sealed', and 'new' modifiers.|
|CS8801|Error|Cannot use local variable or local function '{0}' declared in a top-level statement in this context.|
|[CS8802](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8802)|Error|Only one compilation unit can have top-level statements.|
|[CS8803](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8803)|Error|Top-level statements must precede namespace and type declarations.|
|CS8804|Error|Cannot specify /main if there is a compilation unit with top-level statements.|
|CS8805|Error|Program using top-level statements must be an executable.|
|CS8806|Error|The calling convention of '{0}' is not supported by the language.|
|CS8807|Error|'{0}' is not a valid calling convention specifier for a function pointer.|
|CS8808|Error|'{0}' is not a valid function pointer return type modifier. Valid modifiers are 'ref' and 'ref readonly'.|
|CS8809|Error|A return type can only have one '{0}' modifier.|
|[CS8810](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|'&' on method groups cannot be used in expression trees|
|CS8811|Error|Cannot convert &method group '{0}' to delegate type '{1}'.|
|[CS8812](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8812)|Error|Cannot convert &method group '{0}' to non-function pointer type '{1}'.|
|CS8813|Error|A module initializer must be an ordinary member method|
|CS8814|Error|Module initializer method '{0}' must be accessible at the module level|
|CS8815|Error|Module initializer method '{0}' must be static, and non-virtual, must have no parameters, and must return 'void'|
|CS8816|Error|Module initializer method '{0}' must not be generic and must not be contained in a generic type|
|[CS8817](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial method declarations must have the same return type.|
|[CS8818](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial member declarations must have matching ref return values.|
|[CS8819](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Nullability of reference types in return type doesn't match partial method declaration.|
|CS8820|Error|A static anonymous function cannot contain a reference to '{0}'.|
|CS8821|Error|A static anonymous function cannot contain a reference to 'this' or 'base'.|
|CS8822|Error|Method '{0}' specifies a 'default' constraint for type parameter '{1}', but corresponding type parameter '{2}' of overridden or explicitly implemented method '{3}' is constrained to a reference type or a value type.|
|CS8823|Error|The 'default' constraint is valid on override and explicit interface implementation methods only.|
|[CS8824](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Parameter '{0}' must have a non-null value when exiting because parameter '{1}' is non-null.|
|[CS8825](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|Return value must be non-null because parameter '{0}' is non-null.|
|[CS8826](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Partial method declarations '{0}' and '{1}' have signature differences.|
|CS8830|Error|'{0}': Target runtime doesn't support covariant return types in overrides. Return type must be '{2}' to match overridden member '{1}'|
|CS8831|Error|'{0}': Target runtime doesn't support covariant types in overrides. Type must be '{2}' to match overridden member '{1}'|
|CS8846|Warning|The switch expression does not handle all possible values of its input type (it is not exhaustive). For example, the pattern '{0}' is not covered. However, a pattern with a 'when' clause might successfully match this value.|
|[CS8847](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)|Warning|The switch expression does not handle some null inputs (it is not exhaustive). For example, the pattern '{0}' is not covered. However, a pattern with a 'when' clause might successfully match this value.|
|[CS8848](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Operator '{0}' cannot be used here due to precedence. Use parentheses to disambiguate.|
|[CS8849](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a with-expression.|
|CS8850|Warning|The assembly '{0}' containing type '{1}' references .NET Framework, which is not supported.|
|CS8851|Warning|'{0}' defines 'Equals' but not 'GetHashCode'|
|CS8852|Error|Init-only property or indexer '{0}' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.|
|CS8853|Error|'{0}' must match by init-only of overridden member '{1}'|
|CS8854|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}'.|
|CS8855|Error|Accessors '{0}' and '{1}' should both be init-only or neither|
|CS8856|Error|The 'init' accessor is not valid on static members|
|CS8857|Error|The receiver of a `with` expression must have a non-void type.|
|CS8858|Error|The receiver type '{0}' is not a valid record type and is not a struct type.|
|CS8859|Error|Members named 'Clone' are disallowed in records.|
|CS8860|Warning|Types and aliases should not be named 'record'.|
|[CS8861](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Unexpected argument list.|
|[CS8862](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|A constructor declared in a type with parameter list must have 'this' constructor initializer.|
|[CS8863](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Only a single partial type declaration may have a parameter list|
|CS8864|Error|Records may only inherit from object or another record|
|CS8865|Error|Only records may inherit from records.|
|CS8866|Error|Record member '{0}' must be a readable instance property or field of type '{1}' to match positional parameter '{2}'.|
|[CS8867](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|No accessible copy constructor found in base type '{0}'.|
|[CS8868](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|A copy constructor in a record must call a copy constructor of the base, or a parameterless object constructor if the record inherits from object.|
|CS8869|Error|'{0}' does not override expected method from 'object'.|
|CS8870|Error|'{0}' cannot be sealed because containing record is not sealed.|
|CS8871|Error|'{0}' does not override expected method from '{1}'.|
|CS8872|Error|'{0}' must allow overriding because the containing record is not sealed.|
|CS8873|Error|Record member '{0}' must be public.|
|CS8874|Error|Record member '{0}' must return '{1}'.|
|CS8875|Error|Record member '{0}' must be protected.|
|CS8876|Error|'{0}' does not override expected property from '{1}'.|
|CS8877|Error|Record member '{0}' may not be static.|
|[CS8878](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|A copy constructor '{0}' must be public or protected because the record is not sealed.|
|CS8879|Error|Record member '{0}' must be private.|
|[CS8880](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Auto-implemented property '{0}' must be fully assigned before control is returned to the caller. Consider updating to language version '{1}' to auto-default the property.|
|[CS8881](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Field '{0}' must be fully assigned before control is returned to the caller. Consider updating to language version '{1}' to auto-default the field.|
|[CS8882](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|The out parameter '{0}' must be assigned to before control leaves the current method|
|[CS8883](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Use of possibly unassigned auto-implemented property '{0}'|
|[CS8884](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Use of possibly unassigned field '{0}'|
|[CS8885](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|The 'this' object cannot be used before all of its fields have been assigned. Consider updating to language version '{0}' to auto-default the unassigned fields.|
|[CS8886](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Use of unassigned out parameter '{0}'|
|[CS8887](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Use of unassigned local variable '{0}'|
|CS8888|Error|'managed' calling convention cannot be combined with unmanaged calling convention specifiers.|
|CS8889|Error|The target runtime doesn't support extensible or runtime-environment default calling conventions.|
|CS8890|Error|Type '{0}' is not defined.|
|CS8891|Error|Type '{0}' must be public to be used as a calling convention.|
|[CS8892](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|Method '{0}' will not be used as an entry point because a synchronous entry point '{1}' was found.|
|CS8893|Error|'{0}' is not a valid calling convention type for 'UnmanagedCallersOnly'.|
|CS8894|Error|Cannot use '{0}' as a {1} type on a method attributed with 'UnmanagedCallersOnly'.|
|CS8895|Error|Methods attributed with 'UnmanagedCallersOnly' cannot have generic type parameters and cannot be declared in a generic type.|
|CS8896|Error|'UnmanagedCallersOnly' can only be applied to ordinary static non-abstract, non-virtual methods or static local functions.|
|[CS8897](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|'{0}': static types cannot be used as parameters|
|[CS8898](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|'{0}': static types cannot be used as return types|
|CS8899|Error|Application entry points cannot be attributed with 'UnmanagedCallersOnly'.|
|CS8900|Error|Module initializer cannot be attributed with 'UnmanagedCallersOnly'.|
|CS8901|Error|'{0}' is attributed with 'UnmanagedCallersOnly' and cannot be called directly. Obtain a function pointer to this method.|
|CS8902|Error|'{0}' is attributed with 'UnmanagedCallersOnly' and cannot be converted to a delegate type. Obtain a function pointer to this method.|
|CS8903|Error|'init' accessors cannot be marked 'readonly'. Mark '{0}' readonly instead.|
|[CS8904](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Invalid variance: The type parameter '{1}' must be {3} valid on '{0}' unless language version '{4}' or greater is used. '{1}' is {2}.|
|[CS8905](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|A function pointer cannot be called with named arguments.|
|CS8906|Error|Record equality contract property '{0}' must have a get accessor.|
|CS8907|Warning|Parameter '{0}' is unread. Did you forget to use it to initialize the property with that name?|
|CS8908|Error|The type '{0}' may not be used for a field of a record.|
|CS8909|Warning|Comparison of function pointers might yield an unexpected result, since pointers to the same function may be distinct.|
|[CS8910](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|The primary constructor conflicts with the synthesized copy constructor.|
|CS8911|Error|Using a function pointer type in this context is not supported.|
|[CS8912](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Inheriting from a record with a sealed 'Object.ToString' is not supported in C# {0}. Please use language version '{1}' or greater.|
|CS8913|Error|The positional member '{0}' found corresponding to this parameter is hidden.|
|[CS8914](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|A global using directive cannot be used in a namespace declaration.|
|[CS8915](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|A global using directive must precede all non-global using directives.|
|[CS8916](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Attributes on lambda expressions require a parenthesized parameter list.|
|CS8917|Error|The delegate type could not be inferred.|
|CS8918|Error|Identifier or a simple member access expected.|
|[CS8919](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Target runtime doesn't support static abstract members in interfaces.|
|[CS8920](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|The interface '{0}' cannot be used as type argument. Static member '{1}' does not have a most specific implementation in the interface.|
|[CS8921](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|The parameter of a unary operator must be the containing type, or its type parameter constrained to it.|
|[CS8922](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|The parameter type for ++ or -- operator must be the containing type, or its type parameter constrained to it.|
|[CS8923](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|The return type for ++ or -- operator must either match the parameter type, or be derived from the parameter type, or be the containing type's type parameter constrained to it unless the parameter type is a different type parameter.|
|[CS8924](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|One of the parameters of a binary operator must be the containing type, or its type parameter constrained to it.|
|[CS8925](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|The first operand of an overloaded shift operator must have the same type as the containing type or its type parameter constrained to it|
|[CS8926](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|A static virtual or abstract interface member can be accessed only on a type parameter.|
|[CS8927](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an access of static virtual or abstract interface member|
|[CS8928](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|'{0}' does not implement static interface member '{1}'. '{2}' cannot implement the interface member because it is not static.|
|[CS8929](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|'{0}' cannot implement interface member '{1}' in type '{2}' because the target runtime doesn't support static abstract members in interfaces.|
|[CS8930](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/static-abstract-interfaces)|Error|Explicit implementation of a user-defined operator '{0}' must be declared static|
|CS8931|Error|User-defined conversion in an interface must convert to or from a type parameter on the enclosing type constrained to the enclosing type|
|CS8932|Error|'UnmanagedCallersOnly' method '{0}' cannot implement interface member '{1}' in type '{2}'|
|[CS8933](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Hidden|The using directive for '{0}' appeared previously as global using|
|CS8934|Error|Cannot convert {0} to type '{1}' because the return type does not match the delegate return type|
|CS8935|Error|The AsyncMethodBuilder attribute is disallowed on anonymous methods without an explicit return type.|
|[CS8936](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 10.0. Please use language version {1} or greater.|
|CS8937|Error|At least one top-level statement must be non-empty.|
|CS8938|Error|The #line directive value is missing or out of range|
|CS8939|Error|The #line directive end position must be greater than or equal to the start position|
|CS8940|Error|A generic task-like return type was expected, but the type '{0}' found in 'AsyncMethodBuilder' attribute was not suitable. It must be an unbound generic type of arity one, and its containing type (if any) must be non-generic.|
|CS8941|Error|Interpolated string handler method '{0}' is malformed. It does not return 'void' or 'bool'.|
|CS8942|Error|Interpolated string handler method '{0}' has inconsistent return type. Expected to return '{1}'.|
|[CS8943](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|null is not a valid parameter name. To get access to the receiver of an instance method, use the empty string as the parameter name.|
|[CS8944](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|'{0}' is not an instance method, the receiver cannot be an interpolated string handler argument.|
|[CS8945](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|'{0}' is not a valid parameter name from '{1}'.|
|CS8946|Error|'{0}' is not an interpolated string handler type.|
|CS8947|Warning|Parameter '{0}' occurs after '{1}' in the parameter list, but is used as an argument for interpolated string handler conversions. This will require the caller to reorder parameters with named arguments at the call site. Consider putting the interpolated string handler parameter after all arguments involved.|
|[CS8948](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|InterpolatedStringHandlerArgumentAttribute arguments cannot refer to the parameter the attribute is used on.|
|[CS8949](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|The InterpolatedStringHandlerArgumentAttribute applied to parameter '{0}' is malformed and cannot be interpreted. Construct an instance of '{1}' manually.|
|[CS8950](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Parameter '{0}' is an argument to the interpolated string handler conversion on parameter '{1}', but the corresponding argument is specified after the interpolated string expression. Reorder the arguments to move '{0}' before '{1}'.|
|[CS8951](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|Parameter '{0}' is not explicitly provided, but is used as an argument to the interpolated string handler conversion on parameter '{1}'. Specify the value of '{0}' before '{1}'.|
|[CS8952](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an interpolated string handler conversion.|
|CS8953|Error|An interpolated string handler construction cannot use dynamic. Manually construct an instance of '{0}'.|
|CS8954|Error|Source file can only contain one file-scoped namespace declaration.|
|CS8955|Error|Source file can not contain both file-scoped and normal namespace declarations.|
|CS8956|Error|File-scoped namespace must precede all other members in a file.|
|[CS8957](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Conditional expression is not valid in language version {0} because a common type was not found between '{1}' and '{2}'. To use a target-typed conversion, upgrade to language version {3} or greater.|
|[CS8958](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|The parameterless struct constructor must be 'public'.|
|CS8959|Error|CallerArgumentExpressionAttribute cannot be applied because there are no standard conversions from type '{0}' to type '{1}'|
|CS8960|Warning|The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.|
|CS8961|Warning|The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerFilePathAttribute.|
|CS8962|Warning|The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerMemberNameAttribute.|
|CS8963|Warning|The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect. It is applied with an invalid parameter name.|
|[CS8964](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Error|The CallerArgumentExpressionAttribute may only be applied to parameters with default values|
|[CS8965](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Warning|The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect because it's self-referential.|
|[CS8966](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/parameter-argument-mismatch)|Warning|The CallerArgumentExpressionAttribute applied to parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments|
|[CS8967](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Newlines inside a non-verbatim interpolated string are not supported in C# {0}. Please use language version {1} or greater.|
|CS8968|Error|'{0}': an attribute type argument cannot use type parameters|
|CS8970|Error|Type '{0}' cannot be used in this context because it cannot be represented in metadata.|
|[CS8971](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Warning|InterpolatedStringHandlerArgument has no effect when applied to lambda parameters and will be ignored at the call site.|
|[CS8972](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|A lambda expression with attributes cannot be converted to an expression tree|
|CS8973|Warning|The operation may overflow '{0}' at runtime (use 'unchecked' syntax to override)|
|CS8974|Warning|Converting method group '{0}' to non-delegate type '{1}'. Did you intend to invoke the method?|
|[CS8975](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|The contextual keyword 'var' cannot be used as an explicit lambda return type|
|CS8976|Error|Interpolated string handler conversions that reference the instance being indexed cannot be used in indexer member initializers.|
|[CS8977](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot use 'ref', 'in', or 'out' in the signature of a method attributed with 'UnmanagedCallersOnly'.|
|CS8978|Error|'{0}' cannot be made nullable.|
|CS8979|Error|List patterns may not be used for a value of type '{0}'.|
|CS8980|Error|Slice patterns may only be used once and directly inside a list pattern.|
|[CS8981](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves)|Warning|The type name '{0}' only contains lower-cased ascii characters. Such names may become reserved for the language.|
|[CS8982](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|A constructor declared in a 'struct' with parameter list must have a 'this' initializer that calls the primary constructor or an explicitly declared constructor.|
|[CS8983](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|A 'struct' with field initializers must include an explicitly declared constructor.|
|CS8985|Error|List patterns may not be used for a value of type '{0}'. No suitable 'Length' or 'Count' property was found.|
|CS8986|Error|The 'scoped' modifier of parameter '{0}' doesn't match target '{1}'.|
|CS8987|Error|The 'scoped' modifier of parameter '{0}' doesn't match overridden or implemented member.|
|[CS8988](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|The 'scoped' modifier of parameter '{0}' doesn't match partial definition.|
|CS8996|Error|Raw string literals are not allowed in preprocessor directives.|
|CS8997|Error|Unterminated raw string literal.|
|CS8998|Error|The raw string literal does not start with enough quote characters to allow this many consecutive quote characters as content.|
|CS8999|Error|Line does not start with the same whitespace as the closing line of the raw string literal.|
|CS9000|Error|Raw string literal delimiter must be on its own line.|
|CS9001|Error|Multi-line raw string literals are only allowed in verbatim interpolated strings.|
|CS9002|Error|Multi-line raw string literals must contain at least one line of content.|
|CS9003|Error|Line contains different whitespace than the closing line of the raw string literal: '{0}' versus '{1}'|
|CS9004|Error|Not enough quotes for raw string literal.|
|CS9005|Error|The interpolation must end with the same number of closing braces as the number of '$' characters that the raw string literal started with.|
|CS9006|Error|The interpolated raw string literal does not start with enough '$' characters to allow this many consecutive opening braces as content.|
|CS9007|Error|The interpolated raw string literal does not start with enough '$' characters to allow this many consecutive closing braces as content.|
|CS9008|Error|Sequence of '@' characters is not allowed. A verbatim string or identifier can only have one '@' character and a raw string cannot have any.|
|CS9009|Error|String must start with quote character: "|
|CS9010|Error|Keyword 'enum' cannot be used as a constraint. Did you mean 'struct, System.Enum'?|
|CS9011|Error|Keyword 'delegate' cannot be used as a constraint. Did you mean 'System.Delegate'?|
|CS9012|Error|Unexpected keyword 'record'. Did you mean 'record struct' or 'record class'?|
|CS9013|Error|A string 'null' constant is not supported as a pattern for '{0}'. Use an empty string instead.|
|[CS9014](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Use of possibly unassigned auto-implemented property '{0}'. Consider updating to language version '{1}' to auto-default the property.|
|[CS9015](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Use of possibly unassigned field '{0}'. Consider updating to language version '{1}' to auto-default the field.|
|[CS9016](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Warning|Use of possibly unassigned auto-implemented property '{0}'. Consider updating to language version '{1}' to auto-default the property.|
|[CS9017](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Warning|Use of possibly unassigned field '{0}'. Consider updating to language version '{1}' to auto-default the field.|
|CS9018|Warning|Auto-implemented property '{0}' is read before being explicitly assigned, causing a preceding implicit assignment of 'default'.|
|CS9019|Warning|Field '{0}' is read before being explicitly assigned, causing a preceding implicit assignment of 'default'.|
|CS9020|Warning|The 'this' object is read before all of its fields have been assigned, causing preceding implicit assignments of 'default' to non-explicitly assigned fields.|
|CS9021|Warning|Control is returned to caller before auto-implemented property '{0}' is explicitly assigned, causing a preceding implicit assignment of 'default'.|
|CS9022|Warning|Control is returned to caller before field '{0}' is explicitly assigned, causing a preceding implicit assignment of 'default'.|
|CS9023|Error|User-defined operator '{0}' cannot be declared checked|
|CS9024|Error|An 'implicit' user-defined conversion operator cannot be declared checked|
|CS9025|Error|The operator '{0}' requires a matching non-checked version of the operator to also be defined|
|CS9026|Error|The input string cannot be converted into the equivalent UTF-8 byte representation. {0}|
|CS9027|Error|Unexpected keyword 'unchecked'|
|CS9028|Error|The #line span directive requires space before the first parenthesis, before the character offset, and before the file name|
|CS9029|Error|Types and aliases cannot be named 'required'.|
|CS9030|Error|'{0}' must be required because it overrides required member '{1}'|
|CS9031|Error|Required member '{0}' cannot be hidden by '{1}'.|
|CS9032|Error|Required member '{0}' cannot be less visible or have a setter less visible than the containing type '{1}'.|
|CS9033|Error|Do not use 'System.Runtime.CompilerServices.RequiredMemberAttribute'. Use the 'required' keyword on required fields and properties instead.|
|CS9034|Error|Required member '{0}' must be settable.|
|CS9035|Error|Required member '{0}' must be set in the object initializer or attribute constructor.|
|CS9036|Error|Required member '{0}' must be assigned a value, it cannot use a nested member or collection initializer.|
|CS9037|Error|The required members list for '{0}' is malformed and cannot be interpreted.|
|CS9038|Error|The required members list for the base type '{0}' is malformed and cannot be interpreted. To use this constructor, apply the 'SetsRequiredMembers' attribute.|
|CS9039|Error|This constructor must add 'SetsRequiredMembers' because it chains to a constructor that has that attribute.|
|CS9040|Error|'{2}' cannot satisfy the 'new()' constraint on parameter '{1}' in the generic type or or method '{0}' because '{2}' has required members.|
|CS9041|Error|'{0}' requires compiler feature '{1}', which is not supported by this version of the C# compiler.|
|CS9042|Warning|Required member '{0}' should not be attributed with 'ObsoleteAttribute' unless the containing type is obsolete or all constructors are obsolete.|
|[CS9043](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs9043)|Error|Ref returning properties cannot be required.|
|CS9044|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implicitly implement an inaccessible member.|
|CS9045|Error|Required members are not allowed on the top level of a script or submission.|
|CS9046|Error|One of the parameters of an equality, or inequality operator declared in interface '{0}' must be a type parameter on '{0}' constrained to '{0}'|
|CS9047|Error|Operator '{0}' cannot be applied to operands of type '{1}' and '{2}' that are not UTF-8 byte representations|
|[CS9048](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|The 'scoped' modifier can be used for refs and ref struct values only.|
|CS9049|Error|A fixed field must not be a ref field.|
|[CS9050](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|A ref field cannot refer to a ref struct.|
|CS9051|Error|File-local type '{0}' cannot be used in a member signature in non-file-local type '{1}'.|
|CS9052|Error|File-local type '{0}' cannot use accessibility modifiers.|
|CS9053|Error|File-local type '{0}' cannot be used as a base type of non-file-local type '{1}'.|
|CS9054|Error|File-local type '{0}' must be defined in a top level type; '{0}' is a nested type.|
|[CS9055](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|File-local type '{0}' cannot be used in a 'global using static' directive.|
|CS9056|Error|Types and aliases cannot be named 'file'.|
|CS9057|Warning|Analyzer assembly '{0}' cannot be used because it references version '{1}' of the compiler, which is newer than the currently running version '{2}'.|
|[CS9058](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 11.0. Please use language version {1} or greater.|
|[CS9059](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|A ref field can only be declared in a ref struct.|
|CS9060|Error|Cannot use a numeric constant or relational pattern on '{0}' because it inherits from or extends 'INumberBase\<T\>'. Consider using a type pattern to narrow to a specific numeric type.|
|CS9061|Error|The 'scoped' modifier cannot be used with discard.|
|CS9062|Error|Types and aliases cannot be named 'scoped'.|
|CS9063|Error|UnscopedRefAttribute cannot be applied to this parameter because it is unscoped by default.|
|[CS9064](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Target runtime doesn't support ref fields.|
|CS9065|Error|Do not use 'System.Runtime.CompilerServices.ScopedRefAttribute'. Use the 'scoped' keyword instead.|
|CS9066|Error|UnscopedRefAttribute cannot be applied to parameters that have a 'scoped' modifier.|
|CS9067|Warning|Analyzer reference '{0}' specified multiple times|
|CS9068|Error|File-local type '{0}' must be declared in a file with a unique path. Path '{1}' is used in multiple files.|
|CS9069|Error|File-local type '{0}' cannot be used because the containing file path cannot be converted into the equivalent UTF-8 byte representation. {1}|
|CS9071|Error|The namespace '{1}' already contains a definition for '{0}' in this file.|
|[CS9072](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|A deconstruction variable cannot be declared as a ref local|
|CS9073|Warning|The 'scoped' modifier of parameter '{0}' doesn't match target '{1}'.|
|CS9074|Warning|The 'scoped' modifier of parameter '{0}' doesn't match overridden or implemented member.|
|CS9075|Error|Cannot return a parameter by reference '{0}' because it is scoped to the current method|
|CS9076|Error|Cannot return by reference a member of parameter '{0}' because it is scoped to the current method|
|[CS9077](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot return a parameter by reference '{0}' through a ref parameter; it can only be returned in a return statement|
|[CS9078](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot return by reference a member of parameter '{0}' through a ref parameter; it can only be returned in a return statement|
|[CS9079](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot ref-assign '{1}' to '{0}' because '{1}' can only escape the current method through a return statement.|
|CS9080|Warning|Use of variable '{0}' in this context may expose referenced variables outside of their declaration scope|
|CS9081|Warning|A result of a stackalloc expression of type '{0}' in this context may be exposed outside of the containing method|
|CS9082|Warning|Local '{0}' is returned by reference but was initialized to a value that cannot be returned by reference|
|CS9083|Warning|A member of '{0}' is returned by reference but was initialized to a value that cannot be returned by reference|
|CS9084|Warning|Struct member returns 'this' or other instance members by reference|
|[CS9085](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This ref-assigns '{1}' to '{0}' but '{1}' has a narrower escape scope than '{0}'.|
|[CS9086](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|The branches of the ref conditional operator refer to variables with incompatible declaration scopes|
|[CS9087](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This returns a parameter by reference '{0}' but it is not a ref parameter|
|CS9088|Warning|This returns a parameter by reference '{0}' but it is scoped to the current method|
|[CS9089](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This returns by reference a member of parameter '{0}' that is not a ref or out parameter|
|CS9090|Warning|This returns by reference a member of parameter '{0}' that is scoped to the current method|
|[CS9091](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This returns local '{0}' by reference but it is not a ref local|
|[CS9092](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This returns a member of local '{0}' by reference but it is not a ref local|
|[CS9093](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This ref-assigns '{1}' to '{0}' but '{1}' can only escape the current method through a return statement.|
|[CS9094](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This returns a parameter by reference '{0}' through a ref parameter; but it can only safely be returned in a return statement|
|[CS9095](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This returns by reference a member of parameter '{0}' through a ref parameter; but it can only safely be returned in a return statement|
|[CS9096](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|Cannot ref-assign '{1}' to '{0}' because '{1}' has a wider value escape scope than '{0}' allowing assignment through '{0}' of values with narrower escape scopes than '{1}'.|
|[CS9097](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|This ref-assigns '{1}' to '{0}' but '{1}' has a wider value escape scope than '{0}' allowing assignment through '{0}' of values with narrower escape scopes than '{1}'.|
|[CS9098](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Error|Implicitly typed lambda parameter '{0}' cannot have a default value.|
|[CS9099](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Warning|Parameter {0} has default value '{1:10}' in lambda but '{2:10}' in the target delegate type.|
|[CS9100](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lambda-expression-errors)|Warning|Parameter {0} has params modifier in lambda but not in target delegate type.|
|[CS9101](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|UnscopedRefAttribute can only be applied to struct or virtual interface instance methods and properties, and cannot be applied to constructors or init-only members.|
|[CS9102](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|UnscopedRefAttribute cannot be applied to an interface implementation because implemented member '{0}' doesn't have this attribute.|
|[CS9103](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|'{0}' is defined in a module with an unrecognized RefSafetyRulesAttribute version, expecting '11'.|
|[CS9105](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Cannot use primary constructor parameter '{0}' in this context.|
|[CS9106](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Identifier '{0}' is ambiguous between type '{1}' and parameter '{2}' in this context.|
|[CS9107](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Warning|Parameter '{0}' is captured into the state of the enclosing type and its value is also passed to the base constructor. The value might be captured by the base class as well.|
|[CS9108](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Cannot use parameter '{0}' that has ref-like type inside an anonymous method, lambda expression, query expression, or local function|
|[CS9109](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Cannot use ref, out, or in primary constructor parameter '{0}' inside an instance member|
|[CS9110](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Cannot use primary constructor parameter '{0}' that has ref-like type inside an instance member|
|[CS9111](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Anonymous methods, lambda expressions, query expressions, and local functions inside an instance member of a struct cannot access primary constructor parameter|
|[CS9112](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Anonymous methods, lambda expressions, query expressions, and local functions inside a struct cannot access primary constructor parameter also used inside an instance member|
|[CS9113](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Warning|Parameter '{0}' is unread.|
|[CS9114](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|A primary constructor parameter of a readonly type cannot be assigned to (except in init-only setter of the type or a variable initializer)|
|[CS9115](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|A primary constructor parameter of a readonly type cannot be returned by writable reference|
|[CS9116](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|A primary constructor parameter of a readonly type cannot be used as a ref or out value (except in init-only setter of the type or a variable initializer)|
|[CS9117](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Members of primary constructor parameter '{0}' of a readonly type cannot be modified (except in init-only setter of the type or a variable initializer)|
|[CS9118](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Members of primary constructor parameter '{0}' of a readonly type cannot be returned by writable reference|
|[CS9119](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Members of primary constructor parameter '{0}' of a readonly type cannot be used as a ref or out value (except in init-only setter of the type or a variable initializer)|
|[CS9120](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Cannot return primary constructor parameter '{0}' by reference.|
|[CS9121](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Struct primary constructor parameter '{0}' of type '{1}' causes a cycle in the struct layout|
|[CS9122](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Unexpected parameter list.|
|CS9123|Warning|The '&' operator should not be used on parameters or local variables in async methods.|
|[CS9124](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Warning|Parameter '{0}' is captured into the state of the enclosing type and its value is also used to initialize a field, property, or event.|
|CS9125|Warning|Attribute parameter 'SizeConst' must be specified.|
|[CS9130](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|Using alias cannot be a 'ref' type.|
|[CS9131](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|Only a 'using static' or 'using alias' can be 'unsafe'.|
|[CS9132](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|Using alias cannot be a nullable reference type.|
|[CS9133](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|'static' modifier must precede 'unsafe' modifier.|
|[CS9134](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/pattern-matching-warnings)|Error|A switch expression arm does not begin with a 'case' keyword.|
|[CS9135](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/pattern-matching-warnings)|Error|A constant value of type '{0}' is expected|
|[CS9136](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Error|Cannot use primary constructor parameter of type '{0}' inside an instance member|
|[CS9137](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|The 'interceptors' feature is not enabled in this namespace. Add '{0}' to your project.|
|[CS9138](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Method '{0}' cannot be used as an interceptor because its containing type has type parameters.|
|[CS9139](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Cannot intercept: compilation does not contain a file with path '{0}'.|
|[CS9140](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Cannot intercept: compilation does not contain a file with path '{0}'. Did you mean to use path '{1}'?|
|[CS9141](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|The provided line and character number does not refer to an interceptable method name, but rather to token '{0}'.|
|[CS9142](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|The given file has '{0}' lines, which is fewer than the provided line number '{1}'.|
|[CS9143](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|The given line is '{0}' characters long, which is fewer than the provided character number '{1}'.|
|[CS9144](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Cannot intercept method '{0}' with interceptor '{1}' because the signatures do not match.|
|[CS9146](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|An interceptor method must be an ordinary member method.|
|[CS9147](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|The provided line and character number does not refer to the start of token '{0}'. Did you mean to use line '{1}' and character '{2}'?|
|[CS9148](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Interceptor must have a 'this' parameter matching parameter '{0}' on '{1}'.|
|[CS9149](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Interceptor must not have a 'this' parameter because '{0}' does not have a 'this' parameter.|
|[CS9150](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Interceptor cannot have a 'null' file path.|
|[CS9151](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Possible method name '{0}' cannot be intercepted because it is not being invoked.|
|[CS9152](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Cannot intercept a call in file with path '{0}' because multiple files in the compilation have this path.|
|[CS9153](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|The indicated call is intercepted multiple times.|
|[CS9154](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Warning|Intercepting a call to '{0}' with interceptor '{1}', but the signatures do not match.|
|[CS9155](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Cannot intercept call with '{0}' because it is not accessible within '{1}'.|
|[CS9156](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Cannot intercept call to '{0}' with '{1}' because of a difference in 'scoped' modifiers or '[UnscopedRef]' attributes.|
|[CS9157](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Line and character numbers provided to InterceptsLocationAttribute must be positive.|
|[CS9158](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Warning|Nullability of reference types in return type doesn't match interceptable method '{0}'.|
|[CS9159](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Warning|Nullability of reference types in type of parameter '{0}' doesn't match interceptable method '{1}'.|
|[CS9160](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|A nameof operator cannot be intercepted.|
|[CS9161](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|An interceptor cannot be marked with 'UnmanagedCallersOnlyAttribute'.|
|[CS9162](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|'{0}' type is not valid for 'using static'. Only a class, struct, interface, enum, delegate, or namespace can be used.|
|[CS9163](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/using-directive-errors)|Error|'{0}' is defined in assembly '{1}'.|
|[CS9164](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Cannot convert expression to '{0}' because it is not an assignable variable|
|[CS9165](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Cannot convert expression to '{0}' because it may not be passed or returned by reference|
|[CS9166](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Index is outside the bounds of the inline array|
|[CS9167](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Inline array length must be greater than 0.|
|[CS9168](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Inline array struct must not have explicit layout.|
|[CS9169](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Inline array struct must declare one and only one instance field.|
|[CS9170](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain an inline array access or conversion|
|[CS9171](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Target runtime doesn't support inline array types.|
|[CS9172](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Elements of an inline array type can be accessed only with a single argument implicitly convertible to 'int', 'System.Index', or 'System.Range'.|
|[CS9173](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|An inline array access may not have a named argument specifier|
|[CS9174](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Cannot initialize type '{0}' with a collection expression because the type is not constructible.|
|[CS9175](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/expression-tree-restrictions)|Error|An expression tree may not contain a collection expression.|
|[CS9176](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|There is no target type for the collection expression.|
|[CS9177](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Method '{0}' must be non-generic or have arity {1} to match '{2}'.|
|[CS9178](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Method '{0}' must be non-generic to match '{1}'.|
|[CS9179](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/constructor-errors)|Warning|Primary constructor parameter '{0}' is shadowed by a member from base.|
|[CS9180](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Inline array element field cannot be declared as required, readonly, volatile, or as a fixed size buffer.|
|[CS9181](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Warning|Inline array indexer will not be used for element access expression.|
|[CS9182](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Warning|Inline array 'Slice' method will not be used for element access expression.|
|[CS9183](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Warning|Inline array conversion operator will not be used for conversion from expression of the declaring type.|
|[CS9184](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Warning|'Inline arrays' language feature is not supported for an inline array type that is not valid as a type argument, or has element type that is not valid as a type argument.|
|[CS9185](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|The CollectionBuilderAttribute builder type must be a non-generic class or struct.|
|[CS9186](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|The CollectionBuilderAttribute method name is invalid.|
|[CS9187](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|Could not find an accessible '{0}' method with the expected signature: a static method with a single parameter of type 'ReadOnlySpan\<{1}\>' and return type '{2}'.|
|[CS9188](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|'{0}' has a CollectionBuilderAttribute but no element type.|
|CS9189|Error|foreach statement on an inline array of type '{0}' is not supported|
|[CS9190](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|'readonly' modifier must be specified after 'ref'.|
|[CS9191](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|The 'ref' modifier for argument {0} corresponding to 'in' parameter is equivalent to 'in'. Consider using 'in' instead.|
|[CS9192](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|Argument {0} should be passed with 'ref' or 'in' keyword|
|[CS9193](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|Argument {0} should be a variable because it is passed to a 'ref readonly' parameter|
|[CS9194](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Argument {0} may not be passed with the 'ref' keyword in language version {1}. To pass 'ref' arguments to 'in' parameters, upgrade to language version {2} or greater.|
|[CS9195](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|Argument {0} should be passed with the 'in' keyword|
|[CS9196](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|Reference kind modifier of parameter '{0}' doesn't match the corresponding parameter '{1}' in overridden or implemented member.|
|[CS9197](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|Reference kind modifier of parameter '{0}' doesn't match the corresponding parameter '{1}' in hidden member.|
|[CS9198](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|Reference kind modifier of parameter '{0}' doesn't match the corresponding parameter '{1}' in target.|
|[CS9199](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Error|A ref readonly parameter cannot have the Out attribute.|
|[CS9200](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|A default value is specified for 'ref readonly' parameter '{0}', but 'ref readonly' should be used only for references. Consider declaring the parameter as 'in'.|
|[CS9201](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|Ref field '{0}' should be ref-assigned before use.|
|[CS9202](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 12.0. Please use language version {1} or greater.|
|[CS9203](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|A collection expression of type '{0}' cannot be used in this context because it may be exposed outside of the current scope.|
|[CS9204](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Warning|'{0}' is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.|
|CS9205|Error|Expected interpolated string|
|[CS9206](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|An interceptor cannot be declared in the global namespace.|
|[CS9207](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/source-generator-errors)|Error|Cannot intercept '{0}' because it is not an invocation of an ordinary member method.|
|[CS9208](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Warning|Collection expression of type '{0}' may incur unexpected heap allocations. Consider explicitly creating an array, then converting to '{0}' to make the allocation explicit.|
|[CS9209](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Warning|Collection expression of type '{0}' may incur unexpected heap allocations due to the use of '..' spreads. Consider explicitly creating an array, then converting to '{0}' to make the allocation explicit.|
|[CS9210](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/array-declaration-errors)|Error|This version of '{0}' cannot be used with collection expressions.|
|CS9211|Error|The diagnosticId argument to the 'Experimental' attribute must be a valid identifier|
|CS9212|Error|Spread operator '..' cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'|
|CS9213|Error|Collection expression target '{0}' has no element type.|
|CS9214|Error|Collection expression type must have an applicable constructor that can be called with no arguments.|
|CS9215|Error|Collection expression type '{0}' must have an instance or extension method 'Add' that can be called with a single argument.|
|[CS9216](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lock-semantics)|Warning|A value of type 'System.Threading.Lock' converted to a different type will use likely unintended monitor-based locking in 'lock' statement.|
|[CS9217](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/lock-semantics)|Error|A 'ref' local cannot be preserved across 'await' or 'yield' boundary.|
|[CS9218](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|'{0}' is applicable only with expanded form of non-array params collection which is not supported during dynamic dispatch.|
|CS9222|Error|Collection initializer results in an infinite chain of instantiations of collection '{0}'.|
|[CS9223](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|Creation of params collection '{0}' results in an infinite chain of invocation of constructor '{1}'.|
|[CS9224](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|Method '{0}' cannot be less visible than the member with params collection '{1}'.|
|[CS9225](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|Constructor '{0}' leaves required member '{1}' uninitialized.|
|CS9226|Error|An expression tree may not contain an expanded form of non-array params collection parameter.|
|[CS9227](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|'{0}' does not contain a definition for a suitable instance 'Add' method|
|[CS9228](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/params-arrays)|Error|Non-array params collection type must have an applicable constructor that can be called with no arguments.|
|CS9229|Error|Modifiers cannot be placed on using declarations|
|CS9230|Error|Cannot perform a dynamic invocation on an expression with type '{0}'.|
|CS9231|Error|The data argument to InterceptsLocationAttribute is not in the correct format.|
|CS9232|Error|Version '{0}' of the interceptors format is not supported. The latest supported version is '1'.|
|CS9233|Error|Cannot intercept a call in file '{0}' because it is duplicated elsewhere in the compilation.|
|CS9234|Error|Cannot intercept a call in file '{0}' because a matching file was not found in the compilation.|
|CS9235|Error|The data argument to InterceptsLocationAttribute refers to an invalid position in file '{0}'.|
|CS9236|Info|Compiling requires binding the lambda expression at least {0} times. Consider declaring the lambda expression with explicit parameter types, or if the containing method call is generic, consider using explicit type arguments.|
|[CS9238](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|Cannot use 'yield return' in an 'unsafe' block|
|[CS9239](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/iterator-yield)|Error|The '&' operator cannot be used on parameters or local variables in iterator methods.|
|[CS9240](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Target runtime doesn't support by-ref-like generics.|
|[CS9241](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|'ref struct' is already specified.|
|[CS9242](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|The 'allows' constraint clause must be the last constraint specified|
|[CS9243](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|Cannot allow ref structs for a type parameter known from other constraints to be a class|
|[CS9244](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|The type '{2}' may not be a ref struct or a type parameter allowing ref structs in order to use it as parameter '{1}' in the generic type or method '{0}'|
|[CS9245](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|'{0}' cannot implement interface member '{1}' for ref struct '{2}'.|
|[CS9246](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|A non-virtual instance interface member cannot be accessed on a type parameter that allows ref struct.|
|[CS9247](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|foreach statement cannot operate on enumerators of type '{0}' because it is a type parameter that allows ref struct and it is not known at compile time to implement IDisposable.|
|[CS9248](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial property '{0}' must have an implementation part.|
|[CS9249](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Partial property '{0}' must have a definition part.|
|[CS9250](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|A partial property may not have multiple defining declarations, and cannot be an auto-property.|
|[CS9251](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|A partial property may not have multiple implementing declarations|
|[CS9252](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Property accessor '{0}' must be implemented because it is declared on the definition part|
|[CS9253](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Property accessor '{0}' does not implement any accessor declared on the definition part|
|[CS9254](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Property accessor '{0}' must be '{1}' to match the definition part|
|[CS9255](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial member declarations must have the same type.|
|[CS9256](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Warning|Partial member declarations '{0}' and '{1}' have signature differences.|
|[CS9257](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|Both partial property declarations must be required or neither may be required|
|[CS9258](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Warning|In language version {0}, the 'field' keyword binds to a synthesized backing field for the property. To avoid generating a synthesized backing field, and to refer to the existing member, use 'this.field' or '@field' instead.|
|[CS9259](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/inline-array-errors)|Error|Attribute 'System.Runtime.CompilerServices.InlineArray' cannot be applied to a record struct.|
|[CS9260](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors)|Error|Feature '{0}' is not available in C# 13.0. Please use language version {1} or greater.|
|[CS9261](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Cannot use 'OverloadResolutionPriorityAttribute' on an overriding member.|
|[CS9262](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/overload-resolution)|Error|Cannot use 'OverloadResolutionPriorityAttribute' on this member.|
|[CS9263](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Error|A partial property cannot have an initializer on both the definition and implementation.|
|[CS9264](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Warning|Non-nullable {0} '{1}' must contain a non-null value when exiting constructor. Consider adding the 'required' modifier, or declaring the {0} as nullable, or safely handling the case where 'field' is null in the 'get' accessor.|
|[CS9265](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-modifiers-errors)|Warning|Field '{0}' is never ref-assigned to, and will always have its default value (null reference)|
|[CS9266](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/partial-declarations)|Warning|The '{0}' accessor of property '{1}' should use 'field' because the other accessor is using it.|
|[CS9267](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/ref-struct-errors)|Error|Element type of an iterator may not be a ref struct or a type parameter allowing ref structs|
|CS9268|Warning|'{0}' is for evaluation purposes only and is subject to change or removal in future updates: '{1}'. Suppress this diagnostic to proceed.|
|CS9269|Warning|UnscopedRefAttribute is only valid in C# 11 or later or when targeting net7.0 or later.|
|CS9270|Warning|'InterceptsLocationAttribute(string, int, int)' is not supported. Move to 'InterceptableLocation'-based generation of these attributes instead. (https://github.com/dotnet/roslyn/issues/72133)|
|CS9271|Error|The type 'Microsoft.CodeAnalysis.EmbeddedAttribute' must be non-generic, internal, sealed, non-static, have a parameterless constructor, inherit from System.Attribute, and be able to be applied to any type.|
|CS9272|Error|Implicitly typed lambda parameter '{0}' cannot have the 'params' modifier.|
|CS9273|Error|In language version {0}, 'field' is a keyword within a property accessor. Rename the variable or use the identifier '@field' instead.|
|CS9274|Error|Cannot emit this string literal into the data section because it has XXHash128 collision with another string literal: {0}|
|CS9275|Error|Partial member '{0}' must have an implementation part.|
|CS9276|Error|Partial member '{0}' must have a definition part.|
|CS9277|Error|Partial member '{0}' may not have multiple defining declarations.|
|CS9278|Error|Partial member '{0}' may not have multiple implementing declarations.|
|CS9279|Error|'{0}': partial event cannot have initializer|
|CS9280|Error|'{0}': only the implementing declaration of a partial constructor can have an initializer|
|CS9281|Error|Extension declarations may not have a name.|
|CS9282|Error|Extension declarations can include only methods or properties|
|CS9283|Error|Extensions must be declared in a top-level, non-generic, static class|
|CS9284|Error|The receiver parameter of an extension cannot have a default value|
|CS9285|Error|An extension container can have only one receiver parameter|
|CS9286|Error|'{0}' does not contain a definition for '{1}' and no accessible extension member '{1}' for receiver of type '{0}' could be found (are you missing a using directive or an assembly reference?)|
|CS9287|Error|'{0}': a receiver parameter cannot have the same name as an extension container type parameter|
|CS9288|Error|'{0}': a parameter, local variable, or local function cannot have the same name as an extension container type parameter|
|CS9289|Error|Type parameter '{0}' has the same name as an extension container type parameter|
|CS9290|Error|'{0}': a parameter, local variable, or local function cannot have the same name as an extension parameter|
|CS9291|Error|'value': an automatically-generated parameter name conflicts with an extension parameter name|
|CS9292|Error|Type parameter '{0}' has the same name as an extension parameter|
|CS9293|Error|Cannot use extension parameter '{0}' in this context.|
|CS9294|Error|'value': an automatically-generated parameter name conflicts with an extension type parameter name|
|CS9295|Error|The extended type '{0}' must reference all the type parameters declared by the extension, but type parameter '{1}' is not referenced.|
|CS9296|Error|An expression tree may not contain an extension property access|
|CS9297|Error|'#:' directives cannot be after first token in file|
|CS9298|Error|'#:' directives can be only used in file-based programs ('-features:FileBasedProgram')|
|CS9299|Error|'#:' directives cannot be after '#if' directive|
|CS9300|Error|The 'ref' receiver parameter of an extension block must be a value type or a generic type constrained to struct.|
|CS9301|Error|The 'in' or 'ref readonly' receiver parameter of extension must be a concrete (non-generic) value type.|
|CS9302|Error|'{0}': new protected member declared in an extension block|
|CS9303|Error|'{0}': cannot declare instance members in an extension block with an unnamed receiver parameter|
|CS9304|Error|'{0}': cannot declare init-only accessors in an extension block|
|CS9305|Error|Cannot use modifiers on the unnamed receiver parameter of extension block|
|CS9306|Error|Types and aliases cannot be named 'extension'.|
|CS9307|Error|An expression tree may not contain a named argument specification out of position|
|CS9308|Error|User-defined operator '{0}' must be declared public|
|CS9310|Error|The return type for this operator must be void|
|CS9311|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because one of them is not an operator.|
|CS9312|Error|'{0}': cannot override inherited member '{1}' because one of them is not an operator.|
|CS9313|Error|Overloaded compound assignment operator '{0}' takes one parameter|
|CS9314|Error|'#!' directives can be only used in scripts or file-based programs|
|CS9315|Error|Combined length of user strings used by the program exceeds allowed limit. Adding a string literal requires restarting the application.|

## Statistics

|Severity|Count|
|--------|-----|
|Hidden|3|
|Info|2|
|Warning|340|
|Error|1573|
|Fatal|7|
|**Total**|**1925**|
