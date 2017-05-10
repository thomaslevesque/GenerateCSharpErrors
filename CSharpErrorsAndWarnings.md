# All C# errors and warnings

*Parsed from the [Roslyn source code](https://github.com/dotnet/roslyn) using Roslyn.*

|Code|Severity|Message|
|----|--------|-------|
|CS0006|Error|Metadata file '{0}' could not be found|
|CS0009|Fatal|Metadata file '{0}' could not be opened -- {1}|
|CS0012|Error|The type '{0}' is defined in an assembly that is not referenced. You must add a reference to assembly '{1}'.|
|CS0016|Error|Could not write to output file '{0}' -- '{1}'|
|CS0017|Error|Program has more than one entry point defined. Compile with /main to specify the type that contains the entry point.|
|CS0019|Error|Operator '{0}' cannot be applied to operands of type '{1}' and '{2}'|
|CS0020|Error|Division by constant zero|
|CS0021|Error|Cannot apply indexing with [] to an expression of type '{0}'|
|CS0022|Error|Wrong number of indices inside []; expected {0}|
|CS0023|Error|Operator '{0}' cannot be applied to operand of type '{1}'|
|CS0026|Error|Keyword 'this' is not valid in a static property, static method, or static field initializer|
|CS0027|Error|Keyword 'this' is not available in the current context|
|CS0028|Warning|'{0}' has the wrong signature to be an entry point|
|CS0029|Error|Cannot implicitly convert type '{0}' to '{1}'|
|CS0030|Error|Cannot convert type '{0}' to '{1}'|
|CS0031|Error|Constant value '{0}' cannot be converted to a '{1}'|
|CS0034|Error|Operator '{0}' is ambiguous on operands of type '{1}' and '{2}'|
|CS0035|Error|Operator '{0}' is ambiguous on an operand of type '{1}'|
|CS0036|Error|An out parameter cannot have the In attribute|
|CS0037|Error|Cannot convert null to '{0}' because it is a non-nullable value type|
|CS0039|Error|Cannot convert type '{0}' to '{1}' via a reference conversion, boxing conversion, unboxing conversion, wrapping conversion, or null type conversion|
|CS0041|Fatal|Unexpected error writing debug information -- '{0}'|
|CS0050|Error|Inconsistent accessibility: return type '{1}' is less accessible than method '{0}'|
|CS0051|Error|Inconsistent accessibility: parameter type '{1}' is less accessible than method '{0}'|
|CS0052|Error|Inconsistent accessibility: field type '{1}' is less accessible than field '{0}'|
|CS0053|Error|Inconsistent accessibility: property type '{1}' is less accessible than property '{0}'|
|CS0054|Error|Inconsistent accessibility: indexer return type '{1}' is less accessible than indexer '{0}'|
|CS0055|Error|Inconsistent accessibility: parameter type '{1}' is less accessible than indexer '{0}'|
|CS0056|Error|Inconsistent accessibility: return type '{1}' is less accessible than operator '{0}'|
|CS0057|Error|Inconsistent accessibility: parameter type '{1}' is less accessible than operator '{0}'|
|CS0058|Error|Inconsistent accessibility: return type '{1}' is less accessible than delegate '{0}'|
|CS0059|Error|Inconsistent accessibility: parameter type '{1}' is less accessible than delegate '{0}'|
|CS0060|Error|Inconsistent accessibility: base class '{1}' is less accessible than class '{0}'|
|CS0061|Error|Inconsistent accessibility: base interface '{1}' is less accessible than interface '{0}'|
|CS0065|Error|'{0}': event property must have both add and remove accessors|
|CS0066|Error|'{0}': event must be of a delegate type|
|CS0067|Warning|The event '{0}' is never used|
|CS0068|Error|'{0}': event in interface cannot have initializer|
|CS0069|Error|An event in an interface cannot have add or remove accessors|
|CS0070|Error|The event '{0}' can only appear on the left hand side of += or -= (except when used from within the type '{1}')|
|CS0071|Error|An explicit interface implementation of an event must use event accessor syntax|
|CS0072|Error|'{0}': cannot override; '{1}' is not an event|
|CS0073|Error|An add or remove accessor must have a body|
|CS0074|Error|'{0}': abstract event cannot have initializer|
|CS0075|Error|To cast a negative value, you must enclose the value in parentheses.|
|CS0076|Error|The enumerator name '{0}' is reserved and cannot be used|
|CS0077|Error|The as operator must be used with a reference type or nullable type ('{0}' is a non-nullable value type)|
|CS0078|Warning|The 'l' suffix is easily confused with the digit '1' -- use 'L' for clarity|
|CS0079|Error|The event '{0}' can only appear on the left hand side of += or -=|
|CS0080|Error|Constraints are not allowed on non-generic declarations|
|CS0081|Error|Type parameter declaration must be an identifier not a type|
|CS0082|Error|Type '{1}' already reserves a member called '{0}' with the same parameter types|
|CS0100|Error|The parameter name '{0}' is a duplicate|
|CS0101|Error|The namespace '{1}' already contains a definition for '{0}'|
|CS0102|Error|The type '{0}' already contains a definition for '{1}'|
|CS0103|Error|The name '{0}' does not exist in the current context|
|CS0104|Error|'{0}' is an ambiguous reference between '{1}' and '{2}'|
|CS0105|Warning|The using directive for '{0}' appeared previously in this namespace|
|CS0106|Error|The modifier '{0}' is not valid for this item|
|CS0107|Error|More than one protection modifier|
|CS0108|Warning|'{0}' hides inherited member '{1}'. Use the new keyword if hiding was intended.|
|CS0109|Warning|The member '{0}' does not hide an accessible member. The new keyword is not required.|
|CS0110|Error|The evaluation of the constant value for '{0}' involves a circular definition|
|CS0111|Error|Type '{1}' already defines a member called '{0}' with the same parameter types|
|CS0112|Error|A static member '{0}' cannot be marked as override, virtual, or abstract|
|CS0113|Error|A member '{0}' marked as override cannot be marked as new or virtual|
|CS0114|Warning|'{0}' hides inherited member '{1}'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.|
|CS0115|Error|'{0}': no suitable method found to override|
|CS0116|Error|A namespace cannot directly contain members such as fields or methods|
|CS0117|Error|'{0}' does not contain a definition for '{1}'|
|CS0118|Error|'{0}' is a {1} but is used like a {2}|
|CS0119|Error|'{0}' is a {1}, which is not valid in the given context|
|CS0120|Error|An object reference is required for the non-static field, method, or property '{0}'|
|CS0121|Error|The call is ambiguous between the following methods or properties: '{0}' and '{1}'|
|CS0122|Error|'{0}' is inaccessible due to its protection level|
|CS0123|Error|No overload for '{0}' matches delegate '{1}'|
|CS0126|Error|An object of a type convertible to '{0}' is required|
|CS0127|Error|Since '{0}' returns void, a return keyword must not be followed by an object expression|
|CS0128|Error|A local variable or function named '{0}' is already defined in this scope|
|CS0131|Error|The left-hand side of an assignment must be a variable, property or indexer|
|CS0132|Error|'{0}': a static constructor must be parameterless|
|CS0133|Error|The expression being assigned to '{0}' must be constant|
|CS0134|Error|'{0}' is of type '{1}'. A const field of a reference type other than string can only be initialized with null.|
|CS0136|Error|A local or parameter named '{0}' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter|
|CS0138|Error|A 'using namespace' directive can only be applied to namespaces; '{0}' is a type not a namespace. Consider a 'using static' directive instead|
|CS0139|Error|No enclosing loop out of which to break or continue|
|CS0140|Error|The label '{0}' is a duplicate|
|CS0143|Error|The type '{0}' has no constructors defined|
|CS0144|Error|Cannot create an instance of the abstract class or interface '{0}'|
|CS0145|Error|A const field requires a value to be provided|
|CS0146|Error|Circular base class dependency involving '{0}' and '{1}'|
|CS0148|Error|The delegate '{0}' does not have a valid constructor|
|CS0149|Error|Method name expected|
|CS0150|Error|A constant value is expected|
|CS0151|Error|A switch expression or case label must be a bool, char, string, integral, enum, or corresponding nullable type in C# 6 and earlier.|
|CS0152|Error|The switch statement contains multiple cases with the label value '{0}'|
|CS0153|Error|A goto case is only valid inside a switch statement|
|CS0154|Error|The property or indexer '{0}' cannot be used in this context because it lacks the get accessor|
|CS0155|Error|The type caught or thrown must be derived from System.Exception|
|CS0156|Error|A throw statement with no arguments is not allowed outside of a catch clause|
|CS0157|Error|Control cannot leave the body of a finally clause|
|CS0158|Error|The label '{0}' shadows another label by the same name in a contained scope|
|CS0159|Error|No such label '{0}' within the scope of the goto statement|
|CS0160|Error|A previous catch clause already catches all exceptions of this or of a super type ('{0}')|
|CS0161|Error|'{0}': not all code paths return a value|
|CS0162|Warning|Unreachable code detected|
|CS0163|Error|Control cannot fall through from one case label ('{0}') to another|
|CS0164|Warning|This label has not been referenced|
|CS0165|Error|Use of unassigned local variable '{0}'|
|CS0168|Warning|The variable '{0}' is declared but never used|
|CS0169|Warning|The field '{0}' is never used|
|CS0170|Error|Use of possibly unassigned field '{0}'|
|CS0171|Error|Field '{0}' must be fully assigned before control is returned to the caller|
|CS0172|Error|Type of conditional expression cannot be determined because '{0}' and '{1}' implicitly convert to one another|
|CS0173|Error|Type of conditional expression cannot be determined because there is no implicit conversion between '{0}' and '{1}'|
|CS0174|Error|A base class is required for a 'base' reference|
|CS0175|Error|Use of keyword 'base' is not valid in this context|
|CS0176|Error|Member '{0}' cannot be accessed with an instance reference; qualify it with a type name instead|
|CS0177|Error|The out parameter '{0}' must be assigned to before control leaves the current method|
|CS0178|Error|Invalid rank specifier: expected ',' or ']'|
|CS0179|Error|'{0}' cannot be extern and declare a body|
|CS0180|Error|'{0}' cannot be both extern and abstract|
|CS0181|Error|Attribute constructor parameter '{0}' has type '{1}', which is not a valid attribute parameter type|
|CS0182|Error|An attribute argument must be a constant expression, typeof expression or array creation expression of an attribute parameter type|
|CS0183|Warning|The given expression is always of the provided ('{0}') type|
|CS0184|Warning|The given expression is never of the provided ('{0}') type|
|CS0185|Error|'{0}' is not a reference type as required by the lock statement|
|CS0186|Error|Use of null is not valid in this context|
|CS0188|Error|The 'this' object cannot be used before all of its fields are assigned to|
|CS0190|Error|The __arglist construct is valid only within a variable argument method|
|CS0191|Error|A readonly field cannot be assigned to (except in a constructor or a variable initializer)|
|CS0192|Error|A readonly field cannot be used as a ref or out value (except in a constructor)|
|CS0193|Error|The * or -> operator must be applied to a pointer|
|CS0196|Error|A pointer must be indexed by only one value|
|CS0197|Warning|Using '{0}' as a ref or out value or taking its address may cause a runtime exception because it is a field of a marshal-by-reference class|
|CS0198|Error|A static readonly field cannot be assigned to (except in a static constructor or a variable initializer)|
|CS0199|Error|A static readonly field cannot be used as a ref or out value (except in a static constructor)|
|CS0200|Error|Property or indexer '{0}' cannot be assigned to -- it is read only|
|CS0201|Error|Only assignment, call, increment, decrement, and new object expressions can be used as a statement|
|CS0202|Error|foreach requires that the return type '{0}' of '{1}' must have a suitable public MoveNext method and public Current property|
|CS0204|Error|Only 65534 locals, including those generated by the compiler, are allowed|
|CS0205|Error|Cannot call an abstract base member: '{0}'|
|CS0206|Error|A property or indexer may not be passed as an out or ref parameter|
|CS0208|Error|Cannot take the address of, get the size of, or declare a pointer to a managed type ('{0}')|
|CS0209|Error|The type of a local declared in a fixed statement must be a pointer type|
|CS0210|Error|You must provide an initializer in a fixed or using statement declaration|
|CS0211|Error|Cannot take the address of the given expression|
|CS0212|Error|You can only take the address of an unfixed expression inside of a fixed statement initializer|
|CS0213|Error|You cannot use the fixed statement to take the address of an already fixed expression|
|CS0214|Error|Pointers and fixed size buffers may only be used in an unsafe context|
|CS0215|Error|The return type of operator True or False must be bool|
|CS0216|Error|The operator '{0}' requires a matching operator '{1}' to also be defined|
|CS0217|Error|In order to be applicable as a short circuit operator a user-defined logical operator ('{0}') must have the same return type and parameter types|
|CS0218|Error|In order for '{0}' to be applicable as a short circuit operator, its declaring type '{1}' must define operator true and operator false|
|CS0219|Warning|The variable '{0}' is assigned but its value is never used|
|CS0220|Error|The operation overflows at compile time in checked mode|
|CS0221|Error|Constant value '{0}' cannot be converted to a '{1}' (use 'unchecked' syntax to override)|
|CS0224|Error|A method with vararg cannot be generic, be in a generic type, or have a params parameter|
|CS0225|Error|The params parameter must be a single dimensional array|
|CS0226|Error|An __arglist expression may only appear inside of a call or new expression|
|CS0227|Error|Unsafe code may only appear if compiling with /unsafe|
|CS0229|Error|Ambiguity between '{0}' and '{1}'|
|CS0230|Error|Type and identifier are both required in a foreach statement|
|CS0231|Error|A params parameter must be the last parameter in a formal parameter list|
|CS0233|Error|'{0}' does not have a predefined size, therefore sizeof can only be used in an unsafe context (consider using System.Runtime.InteropServices.Marshal.SizeOf)|
|CS0234|Error|The type or namespace name '{0}' does not exist in the namespace '{1}' (are you missing an assembly reference?)|
|CS0236|Error|A field initializer cannot reference the non-static field, method, or property '{0}'|
|CS0238|Error|'{0}' cannot be sealed because it is not an override|
|CS0239|Error|'{0}': cannot override inherited member '{1}' because it is sealed|
|CS0242|Error|The operation in question is undefined on void pointers|
|CS0243|Error|The Conditional attribute is not valid on '{0}' because it is an override method|
|CS0244|Error|Neither 'is' nor 'as' is valid on pointer types|
|CS0245|Error|Destructors and object.Finalize cannot be called directly. Consider calling IDisposable.Dispose if available.|
|CS0246|Error|The type or namespace name '{0}' could not be found (are you missing a using directive or an assembly reference?)|
|CS0247|Error|Cannot use a negative size with stackalloc|
|CS0248|Error|Cannot create an array with a negative size|
|CS0249|Error|Do not override object.Finalize. Instead, provide a destructor.|
|CS0250|Error|Do not directly call your base class Finalize method. It is called automatically from your destructor.|
|CS0251|Warning|Indexing an array with a negative index (array indices always start at zero)|
|CS0252|Warning|Possible unintended reference comparison; to get a value comparison, cast the left hand side to type '{0}'|
|CS0253|Warning|Possible unintended reference comparison; to get a value comparison, cast the right hand side to type '{0}'|
|CS0254|Error|The right hand side of a fixed statement assignment may not be a cast expression|
|CS0255|Error|stackalloc may not be used in a catch or finally block|
|CS0257|Error|An __arglist parameter must be the last parameter in a formal parameter list|
|CS0260|Error|Missing partial modifier on declaration of type '{0}'; another partial declaration of this type exists|
|CS0261|Error|Partial declarations of '{0}' must be all classes, all structs, or all interfaces|
|CS0262|Error|Partial declarations of '{0}' have conflicting accessibility modifiers|
|CS0263|Error|Partial declarations of '{0}' must not specify different base classes|
|CS0264|Error|Partial declarations of '{0}' must have the same type parameter names in the same order|
|CS0265|Error|Partial declarations of '{0}' have inconsistent constraints for type parameter '{1}'|
|CS0266|Error|Cannot implicitly convert type '{0}' to '{1}'. An explicit conversion exists (are you missing a cast?)|
|CS0267|Error|The 'partial' modifier can only appear immediately before 'class', 'struct', 'interface', or 'void'|
|CS0268|Error|Imported type '{0}' is invalid. It contains a circular base class dependency.|
|CS0269|Error|Use of unassigned out parameter '{0}'|
|CS0270|Error|Array size cannot be specified in a variable declaration (try initializing with a 'new' expression)|
|CS0271|Error|The property or indexer '{0}' cannot be used in this context because the get accessor is inaccessible|
|CS0272|Error|The property or indexer '{0}' cannot be used in this context because the set accessor is inaccessible|
|CS0273|Error|The accessibility modifier of the '{0}' accessor must be more restrictive than the property or indexer '{1}'|
|CS0274|Error|Cannot specify accessibility modifiers for both accessors of the property or indexer '{0}'|
|CS0275|Error|'{0}': accessibility modifiers may not be used on accessors in an interface|
|CS0276|Error|'{0}': accessibility modifiers on accessors may only be used if the property or indexer has both a get and a set accessor|
|CS0277|Error|'{0}' does not implement interface member '{1}'. '{2}' is not public.|
|CS0278|Warning|'{0}' does not implement the '{1}' pattern. '{2}' is ambiguous with '{3}'.|
|CS0279|Warning|'{0}' does not implement the '{1}' pattern. '{2}' is either static or not public.|
|CS0280|Warning|'{0}' does not implement the '{1}' pattern. '{2}' has the wrong signature.|
|CS0281|Error|Friend access was granted by '{0}', but the public key of the output assembly does not match that specified by the attribute in the granting assembly.|
|CS0282|Warning|There is no defined ordering between fields in multiple declarations of partial struct '{0}'. To specify an ordering, all instance fields must be in the same declaration.|
|CS0283|Error|The type '{0}' cannot be declared const|
|CS0304|Error|Cannot create an instance of the variable type '{0}' because it does not have the new() constraint|
|CS0305|Error|Using the generic {1} '{0}' requires {2} type arguments|
|CS0306|Error|The type '{0}' may not be used as a type argument|
|CS0307|Error|The {1} '{0}' cannot be used with type arguments|
|CS0308|Error|The non-generic {1} '{0}' cannot be used with type arguments|
|CS0310|Error|'{2}' must be a non-abstract type with a public parameterless constructor in order to use it as parameter '{1}' in the generic type or method '{0}'|
|CS0311|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no implicit reference conversion from '{3}' to '{1}'.|
|CS0312|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. The nullable type '{3}' does not satisfy the constraint of '{1}'.|
|CS0313|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. The nullable type '{3}' does not satisfy the constraint of '{1}'. Nullable types can not satisfy any interface constraints.|
|CS0314|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no boxing conversion or type parameter conversion from '{3}' to '{1}'.|
|CS0315|Error|The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no boxing conversion from '{3}' to '{1}'.|
|CS0316|Error|The parameter name '{0}' conflicts with an automatically-generated parameter name|
|CS0400|Error|The type or namespace name '{0}' could not be found in the global namespace (are you missing an assembly reference?)|
|CS0401|Error|The new() constraint must be the last constraint specified|
|CS0402|Warning|'{0}': an entry point cannot be generic or in a generic type|
|CS0403|Error|Cannot convert null to type parameter '{0}' because it could be a non-nullable value type. Consider using 'default({0})' instead.|
|CS0404|Error|Cannot apply attribute class '{0}' because it is generic|
|CS0405|Error|Duplicate constraint '{0}' for type parameter '{1}'|
|CS0406|Error|The class type constraint '{0}' must come before any other constraints|
|CS0407|Error|'{1} {0}' has the wrong return type|
|CS0409|Error|A constraint clause has already been specified for type parameter '{0}'. All of the constraints for a type parameter must be specified in a single where clause.|
|CS0411|Error|The type arguments for method '{0}' cannot be inferred from the usage. Try specifying the type arguments explicitly.|
|CS0412|Error|'{0}': a parameter, local variable, or local function cannot have the same name as a method type parameter|
|CS0413|Error|The type parameter '{0}' cannot be used with the 'as' operator because it does not have a class type constraint nor a 'class' constraint|
|CS0414|Warning|The field '{0}' is assigned but its value is never used|
|CS0415|Error|The '{0}' attribute is valid only on an indexer that is not an explicit interface member declaration|
|CS0416|Error|'{0}': an attribute argument cannot use type parameters|
|CS0417|Error|'{0}': cannot provide arguments when creating an instance of a variable type|
|CS0418|Error|'{0}': an abstract class cannot be sealed or static|
|CS0419|Warning|Ambiguous reference in cref attribute: '{0}'. Assuming '{1}', but could have also matched other overloads including '{2}'.|
|CS0420|Warning|'{0}': a reference to a volatile field will not be treated as volatile|
|CS0423|Error|Since '{1}' has the ComImport attribute, '{0}' must be extern or abstract|
|CS0424|Error|'{0}': a class with the ComImport attribute cannot specify a base class|
|CS0425|Error|The constraints for type parameter '{0}' of method '{1}' must match the constraints for type parameter '{2}' of interface method '{3}'. Consider using an explicit interface implementation instead.|
|CS0426|Error|The type name '{0}' does not exist in the type '{1}'|
|CS0428|Error|Cannot convert method group '{0}' to non-delegate type '{1}'. Did you intend to invoke the method?|
|CS0430|Error|The extern alias '{0}' was not specified in a /reference option|
|CS0431|Error|Cannot use alias '{0}' with '::' since the alias references a type. Use '.' instead.|
|CS0432|Error|Alias '{0}' not found|
|CS0433|Error|The type '{1}' exists in both '{0}' and '{2}'|
|CS0434|Error|The namespace '{1}' in '{0}' conflicts with the type '{3}' in '{2}'|
|CS0435|Warning|The namespace '{1}' in '{0}' conflicts with the imported type '{3}' in '{2}'. Using the namespace defined in '{0}'.|
|CS0436|Warning|The type '{1}' in '{0}' conflicts with the imported type '{3}' in '{2}'. Using the type defined in '{0}'.|
|CS0437|Warning|The type '{1}' in '{0}' conflicts with the imported namespace '{3}' in '{2}'. Using the type defined in '{0}'.|
|CS0438|Error|The type '{1}' in '{0}' conflicts with the namespace '{3}' in '{2}'|
|CS0439|Error|An extern alias declaration must precede all other elements defined in the namespace|
|CS0440|Warning|Defining an alias named 'global' is ill-advised since 'global::' always references the global namespace and not an alias|
|CS0441|Error|'{0}': a class cannot be both static and sealed|
|CS0442|Error|'{0}': abstract properties cannot have private accessors|
|CS0443|Error|Syntax error; value expected|
|CS0445|Error|Cannot modify the result of an unboxing conversion|
|CS0446|Error|Foreach cannot operate on a '{0}'. Did you intend to invoke the '{0}'?|
|CS0448|Error|The return type for ++ or -- operator must match the parameter type or be derived from the parameter type|
|CS0449|Error|The 'class' or 'struct' constraint must come before any other constraints|
|CS0450|Error|'{0}': cannot specify both a constraint class and the 'class' or 'struct' constraint|
|CS0451|Error|The 'new()' constraint cannot be used with the 'struct' constraint|
|CS0452|Error|The type '{2}' must be a reference type in order to use it as parameter '{1}' in the generic type or method '{0}'|
|CS0453|Error|The type '{2}' must be a non-nullable value type in order to use it as parameter '{1}' in the generic type or method '{0}'|
|CS0454|Error|Circular constraint dependency involving '{0}' and '{1}'|
|CS0455|Error|Type parameter '{0}' inherits conflicting constraints '{1}' and '{2}'|
|CS0456|Error|Type parameter '{1}' has the 'struct' constraint so '{1}' cannot be used as a constraint for '{0}'|
|CS0457|Error|Ambiguous user defined conversions '{0}' and '{1}' when converting from '{2}' to '{3}'|
|CS0458|Warning|The result of the expression is always 'null' of type '{0}'|
|CS0459|Error|Cannot take the address of a read-only local variable|
|CS0460|Error|Constraints for override and explicit interface implementation methods are inherited from the base method, so they cannot be specified directly|
|CS0462|Error|The inherited members '{0}' and '{1}' have the same signature in type '{2}', so they cannot be overridden|
|CS0463|Error|Evaluation of the decimal constant expression failed|
|CS0464|Warning|Comparing with null of type '{0}' always produces 'false'|
|CS0465|Warning|Introducing a 'Finalize' method can interfere with destructor invocation. Did you intend to declare a destructor?|
|CS0466|Error|'{0}' should not have a params parameter since '{1}' does not|
|CS0469|Warning|The 'goto case' value is not implicitly convertible to type '{0}'|
|CS0470|Error|Method '{0}' cannot implement interface accessor '{1}' for type '{2}'. Use an explicit interface implementation.|
|CS0472|Warning|The result of the expression is always '{0}' since a value of type '{1}' is never equal to 'null' of type '{2}'|
|CS0473|Warning|Explicit interface implementation '{0}' matches more than one interface member. Which interface member is actually chosen is implementation-dependent. Consider using a non-explicit implementation instead.|
|CS0500|Error|'{0}' cannot declare a body because it is marked abstract|
|CS0501|Error|'{0}' must declare a body because it is not marked abstract, extern, or partial|
|CS0502|Error|'{0}' cannot be both abstract and sealed|
|CS0503|Error|The abstract method '{0}' cannot be marked virtual|
|CS0504|Error|The constant '{0}' cannot be marked static|
|CS0505|Error|'{0}': cannot override because '{1}' is not a function|
|CS0506|Error|'{0}': cannot override inherited member '{1}' because it is not marked virtual, abstract, or override|
|CS0507|Error|'{0}': cannot change access modifiers when overriding '{1}' inherited member '{2}'|
|CS0508|Error|'{0}': return type must be '{2}' to match overridden member '{1}'|
|CS0509|Error|'{0}': cannot derive from sealed type '{1}'|
|CS0513|Error|'{0}' is abstract but it is contained in non-abstract class '{1}'|
|CS0514|Error|'{0}': static constructor cannot have an explicit 'this' or 'base' constructor call|
|CS0515|Error|'{0}': access modifiers are not allowed on static constructors|
|CS0516|Error|Constructor '{0}' cannot call itself|
|CS0517|Error|'{0}' has no base class and cannot call a base constructor|
|CS0518|Error|Predefined type '{0}' is not defined or imported|
|CS0522|Error|'{0}': structs cannot call base class constructors|
|CS0523|Error|Struct member '{0}' of type '{1}' causes a cycle in the struct layout|
|CS0524|Error|'{0}': interfaces cannot declare types|
|CS0525|Error|Interfaces cannot contain fields|
|CS0526|Error|Interfaces cannot contain constructors|
|CS0527|Error|Type '{0}' in interface list is not an interface|
|CS0528|Error|'{0}' is already listed in interface list|
|CS0529|Error|Inherited interface '{1}' causes a cycle in the interface hierarchy of '{0}'|
|CS0531|Error|'{0}': interface members cannot have a definition|
|CS0533|Error|'{0}' hides inherited abstract member '{1}'|
|CS0534|Error|'{0}' does not implement inherited abstract member '{1}'|
|CS0535|Error|'{0}' does not implement interface member '{1}'|
|CS0537|Error|The class System.Object cannot have a base class or implement an interface|
|CS0538|Error|'{0}' in explicit interface declaration is not an interface|
|CS0539|Error|'{0}' in explicit interface declaration is not a member of interface|
|CS0540|Error|'{0}': containing type does not implement interface '{1}'|
|CS0541|Error|'{0}': explicit interface declaration can only be declared in a class or struct|
|CS0542|Error|'{0}': member names cannot be the same as their enclosing type|
|CS0543|Error|'{0}': the enumerator value is too large to fit in its type|
|CS0544|Error|'{0}': cannot override because '{1}' is not a property|
|CS0545|Error|'{0}': cannot override because '{1}' does not have an overridable get accessor|
|CS0546|Error|'{0}': cannot override because '{1}' does not have an overridable set accessor|
|CS0547|Error|'{0}': property or indexer cannot have void type|
|CS0548|Error|'{0}': property or indexer must have at least one accessor|
|CS0549|Error|'{0}' is a new virtual member in sealed class '{1}'|
|CS0550|Error|'{0}' adds an accessor not found in interface member '{1}'|
|CS0551|Error|Explicit interface implementation '{0}' is missing accessor '{1}'|
|CS0552|Error|'{0}': user-defined conversions to or from an interface are not allowed|
|CS0553|Error|'{0}': user-defined conversions to or from a base class are not allowed|
|CS0554|Error|'{0}': user-defined conversions to or from a derived class are not allowed|
|CS0555|Error|User-defined operator cannot take an object of the enclosing type and convert to an object of the enclosing type|
|CS0556|Error|User-defined conversion must convert to or from the enclosing type|
|CS0557|Error|Duplicate user-defined conversion in type '{0}'|
|CS0558|Error|User-defined operator '{0}' must be declared static and public|
|CS0559|Error|The parameter type for ++ or -- operator must be the containing type|
|CS0562|Error|The parameter of a unary operator must be the containing type|
|CS0563|Error|One of the parameters of a binary operator must be the containing type|
|CS0564|Error|The first operand of an overloaded shift operator must have the same type as the containing type, and the type of the second operand must be int|
|CS0567|Error|Interfaces cannot contain operators|
|CS0568|Error|Structs cannot contain explicit parameterless constructors|
|CS0569|Error|'{0}': cannot override '{1}' because it is not supported by the language|
|CS0570|Error|'{0}' is not supported by the language|
|CS0571|Error|'{0}': cannot explicitly call operator or accessor|
|CS0572|Error|'{0}': cannot reference a type through an expression; try '{1}' instead|
|CS0573|Error|'{0}': cannot have instance property or field initializers in structs|
|CS0574|Error|Name of destructor must match name of class|
|CS0575|Error|Only class types can contain destructors|
|CS0576|Error|Namespace '{1}' contains a definition conflicting with alias '{0}'|
|CS0577|Error|The Conditional attribute is not valid on '{0}' because it is a constructor, destructor, operator, or explicit interface implementation|
|CS0578|Error|The Conditional attribute is not valid on '{0}' because its return type is not void|
|CS0579|Error|Duplicate '{0}' attribute|
|CS0582|Error|The Conditional attribute is not valid on interface members|
|CS0590|Error|User-defined operators cannot return void|
|CS0591|Error|Invalid value for argument to '{0}' attribute|
|CS0592|Error|Attribute '{0}' is not valid on this declaration type. It is only valid on '{1}' declarations.|
|CS0594|Error|Floating-point constant is outside the range of type '{0}'|
|CS0595|Error|Invalid real literal.|
|CS0596|Error|The Guid attribute must be specified with the ComImport attribute|
|CS0599|Error|Invalid value for named attribute argument '{0}'|
|CS0601|Error|The DllImport attribute must be specified on a method marked 'static' and 'extern'|
|CS0610|Error|Field or property cannot be of type '{0}'|
|CS0611|Error|Array elements cannot be of type '{0}'|
|CS0612|Warning|'{0}' is obsolete|
|CS0616|Error|'{0}' is not an attribute class|
|CS0617|Error|'{0}' is not a valid named attribute argument. Named attribute arguments must be fields which are not readonly, static, or const, or read-write properties which are public and not static.|
|CS0618|Warning|'{0}' is obsolete: '{1}'|
|CS0619|Error|'{0}' is obsolete: '{1}'|
|CS0620|Error|Indexers cannot have void type|
|CS0621|Error|'{0}': virtual or abstract members cannot be private|
|CS0622|Error|Can only use array initializer expressions to assign to array types. Try using a new expression instead.|
|CS0623|Error|Array initializers can only be used in a variable or field initializer. Try using a new expression instead.|
|CS0625|Error|'{0}': instance field types marked with StructLayout(LayoutKind.Explicit) must have a FieldOffset attribute|
|CS0626|Warning|Method, operator, or accessor '{0}' is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation.|
|CS0628|Warning|'{0}': new protected member declared in sealed class|
|CS0629|Error|Conditional member '{0}' cannot implement interface member '{1}' in type '{2}'|
|CS0631|Error|ref and out are not valid in this context|
|CS0633|Error|The argument to the '{0}' attribute must be a valid identifier|
|CS0636|Error|The FieldOffset attribute can only be placed on members of types marked with the StructLayout(LayoutKind.Explicit)|
|CS0637|Error|The FieldOffset attribute is not allowed on static or const fields|
|CS0641|Error|Attribute '{0}' is only valid on classes derived from System.Attribute|
|CS0642|Warning|Possible mistaken empty statement|
|CS0643|Error|'{0}' duplicate named attribute argument|
|CS0644|Error|'{0}' cannot derive from special class '{1}'|
|CS0646|Error|Cannot specify the DefaultMember attribute on a type containing an indexer|
|CS0648|Error|'{0}' is a type not supported by the language|
|CS0649|Warning|Field '{0}' is never assigned to, and will always have its default value {1}|
|CS0650|Error|Bad array declarator: To declare a managed array the rank specifier precedes the variable's identifier. To declare a fixed size buffer field, use the fixed keyword before the field type.|
|CS0652|Warning|Comparison to integral constant is useless; the constant is outside the range of type '{0}'|
|CS0653|Error|Cannot apply attribute class '{0}' because it is abstract|
|CS0655|Error|'{0}' is not a valid named attribute argument because it is not a valid attribute parameter type|
|CS0656|Error|Missing compiler required member '{0}.{1}'|
|CS0657|Warning|'{0}' is not a valid attribute location for this declaration. Valid attribute locations for this declaration are '{1}'. All attributes in this block will be ignored.|
|CS0658|Warning|'{0}' is not a recognized attribute location. Valid attribute locations for this declaration are '{1}'. All attributes in this block will be ignored.|
|CS0659|Warning|'{0}' overrides Object.Equals(object o) but does not override Object.GetHashCode()|
|CS0660|Warning|'{0}' defines operator == or operator != but does not override Object.Equals(object o)|
|CS0661|Warning|'{0}' defines operator == or operator != but does not override Object.GetHashCode()|
|CS0662|Error|Cannot specify only Out attribute on a ref parameter. Use both In and Out attributes, or neither.|
|CS0663|Error|'{0}' cannot define overloaded methods that differ only on ref and out|
|CS0664|Error|Literal of type double cannot be implicitly converted to type '{1}'; use an '{0}' suffix to create a literal of this type|
|CS0665|Warning|Assignment in conditional expression is always constant; did you mean to use == instead of = ?|
|CS0666|Error|'{0}': new protected member declared in struct|
|CS0668|Error|Two indexers have different names; the IndexerName attribute must be used with the same name on every indexer within a type|
|CS0669|Error|A class with the ComImport attribute cannot have a user-defined constructor|
|CS0670|Error|Field cannot have void type|
|CS0672|Warning|Member '{0}' overrides obsolete member '{1}'. Add the Obsolete attribute to '{0}'.|
|CS0673|Error|System.Void cannot be used from C# -- use typeof(void) to get the void type object|
|CS0674|Error|Do not use 'System.ParamArrayAttribute'. Use the 'params' keyword instead.|
|CS0675|Warning|Bitwise-or operator used on a sign-extended operand; consider casting to a smaller unsigned type first|
|CS0677|Error|'{0}': a volatile field cannot be of the type '{1}'|
|CS0678|Error|'{0}': a field cannot be both volatile and readonly|
|CS0681|Error|The modifier 'abstract' is not valid on fields. Try using a property instead.|
|CS0682|Error|'{0}' cannot implement '{1}' because it is not supported by the language|
|CS0683|Error|'{0}' explicit method implementation cannot implement '{1}' because it is an accessor|
|CS0684|Warning|'{0}' interface marked with 'CoClassAttribute' not marked with 'ComImportAttribute'|
|CS0685|Error|Conditional member '{0}' cannot have an out parameter|
|CS0686|Error|Accessor '{0}' cannot implement interface member '{1}' for type '{2}'. Use an explicit interface implementation.|
|CS0687|Error|The namespace alias qualifier '::' always resolves to a type or namespace so is illegal here. Consider using '.' instead.|
|CS0689|Error|Cannot derive from '{0}' because it is a type parameter|
|CS0692|Error|Duplicate type parameter '{0}'|
|CS0693|Warning|Type parameter '{0}' has the same name as the type parameter from outer type '{1}'|
|CS0694|Error|Type parameter '{0}' has the same name as the containing type, or method|
|CS0695|Error|'{0}' cannot implement both '{1}' and '{2}' because they may unify for some type parameter substitutions|
|CS0698|Error|A generic type cannot derive from '{0}' because it is an attribute class|
|CS0699|Error|'{1}' does not define type parameter '{0}'|
|CS0701|Error|'{0}' is not a valid constraint. A type used as a constraint must be an interface, a non-sealed class or a type parameter.|
|CS0702|Error|Constraint cannot be special class '{0}'|
|CS0703|Error|Inconsistent accessibility: constraint type '{1}' is less accessible than '{0}'|
|CS0704|Error|Cannot do member lookup in '{0}' because it is a type parameter|
|CS0706|Error|Invalid constraint type. A type used as a constraint must be an interface, a non-sealed class or a type parameter.|
|CS0708|Error|'{0}': cannot declare instance members in a static class|
|CS0709|Error|'{1}': cannot derive from static class '{0}'|
|CS0710|Error|Static classes cannot have instance constructors|
|CS0711|Error|Static classes cannot contain destructors|
|CS0712|Error|Cannot create an instance of the static class '{0}'|
|CS0713|Error|Static class '{0}' cannot derive from type '{1}'. Static classes must derive from object.|
|CS0714|Error|'{0}': static classes cannot implement interfaces|
|CS0715|Error|'{0}': static classes cannot contain user-defined operators|
|CS0716|Error|Cannot convert to static type '{0}'|
|CS0717|Error|'{0}': static classes cannot be used as constraints|
|CS0718|Error|'{0}': static types cannot be used as type arguments|
|CS0719|Error|'{0}': array elements cannot be of static type|
|CS0720|Error|'{0}': cannot declare indexers in a static class|
|CS0721|Error|'{0}': static types cannot be used as parameters|
|CS0722|Error|'{0}': static types cannot be used as return types|
|CS0723|Error|Cannot declare a variable of static type '{0}'|
|CS0724|Error|A throw statement with no arguments is not allowed in a finally clause that is nested inside the nearest enclosing catch clause|
|CS0726|Error|'{0}' is not a valid format specifier|
|CS0728|Warning|Possibly incorrect assignment to local '{0}' which is the argument to a using or lock statement. The Dispose call or unlocking will happen on the original value of the local.|
|CS0729|Error|Type '{0}' is defined in this assembly, but a type forwarder is specified for it|
|CS0730|Error|Cannot forward type '{0}' because it is a nested type of '{1}'|
|CS0731|Error|The type forwarder for type '{0}' in assembly '{1}' causes a cycle|
|CS0734|Error|The /moduleassemblyname option may only be specified when building a target type of 'module'|
|CS0735|Error|Invalid type specified as an argument for TypeForwardedTo attribute|
|CS0736|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement an interface member because it is static.|
|CS0737|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement an interface member because it is not public.|
|CS0738|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because it does not have the matching return type of '{3}'.|
|CS0739|Error|'{0}' duplicate TypeForwardedToAttribute|
|CS0742|Error|A query body must end with a select clause or a group clause|
|CS0743|Error|Expected contextual keyword 'on'|
|CS0744|Error|Expected contextual keyword 'equals'|
|CS0745|Error|Expected contextual keyword 'by'|
|CS0746|Error|Invalid anonymous type member declarator. Anonymous type members must be declared with a member assignment, simple name or member access.|
|CS0747|Error|Invalid initializer member declarator|
|CS0748|Error|Inconsistent lambda parameter usage; parameter types must be all explicit or all implicit|
|CS0750|Error|A partial method cannot have access modifiers or the virtual, abstract, override, new, sealed, or extern modifiers|
|CS0751|Error|A partial method must be declared within a partial class or partial struct|
|CS0752|Error|A partial method cannot have out parameters|
|CS0753|Error|Only methods, classes, structs, or interfaces may be partial|
|CS0754|Error|A partial method may not explicitly implement an interface method|
|CS0755|Error|Both partial method declarations must be extension methods or neither may be an extension method|
|CS0756|Error|A partial method may not have multiple defining declarations|
|CS0757|Error|A partial method may not have multiple implementing declarations|
|CS0758|Error|Both partial method declarations must use a params parameter or neither may use a params parameter|
|CS0759|Error|No defining declaration found for implementing declaration of partial method '{0}'|
|CS0761|Error|Partial method declarations of '{0}' have inconsistent type parameter constraints|
|CS0762|Error|Cannot create delegate from method '{0}' because it is a partial method without an implementing declaration|
|CS0763|Error|Both partial method declarations must be static or neither may be static|
|CS0764|Error|Both partial method declarations must be unsafe or neither may be unsafe|
|CS0765|Error|Partial methods with only a defining declaration or removed conditional methods cannot be used in expression trees|
|CS0766|Error|Partial methods must have a void return type|
|CS0767|Error|Cannot inherit interface '{0}' with the specified type parameters because it causes method '{1}' to contain overloads which differ only on ref and out|
|CS0768|Error|Constructor '{0}' cannot call itself through another constructor|
|CS0809|Warning|Obsolete member '{0}' overrides non-obsolete member '{1}'|
|CS0811|Warning|The fully qualified name for '{0}' is too long for debug information. Compile without '/debug' option.|
|CS0815|Error|Cannot assign {0} to an implicitly-typed variable|
|CS0818|Error|Implicitly-typed variables must be initialized|
|CS0819|Error|Implicitly-typed variables cannot have multiple declarators|
|CS0820|Error|Cannot initialize an implicitly-typed variable with an array initializer|
|CS0821|Error|Implicitly-typed local variables cannot be fixed|
|CS0822|Error|Implicitly-typed variables cannot be constant|
|CS0824|Warning|Constructor '{0}' is marked external|
|CS0825|Error|The contextual keyword 'var' may only appear within a local variable declaration or in script code|
|CS0826|Error|No best type found for implicitly-typed array|
|CS0828|Error|Cannot assign '{0}' to anonymous type property|
|CS0831|Error|An expression tree may not contain a base access|
|CS0832|Error|An expression tree may not contain an assignment operator|
|CS0833|Error|An anonymous type cannot have multiple properties with the same name|
|CS0834|Error|A lambda expression with a statement body cannot be converted to an expression tree|
|CS0835|Error|Cannot convert lambda to an expression tree whose type argument '{0}' is not a delegate type|
|CS0836|Error|Cannot use anonymous type in a constant expression|
|CS0837|Error|The first operand of an 'is' or 'as' operator may not be a lambda expression, anonymous method, or method group.|
|CS0838|Error|An expression tree may not contain a multidimensional array initializer|
|CS0839|Error|Argument missing|
|CS0841|Error|Cannot use local variable '{0}' before it is declared|
|CS0842|Error|'{0}': Auto-implemented properties cannot be used inside a type marked with StructLayout(LayoutKind.Explicit)|
|CS0843|Error|Auto-implemented property '{0}' must be fully assigned before control is returned to the caller.|
|CS0844|Error|Cannot use local variable '{0}' before it is declared. The declaration of the local variable hides the field '{1}'.|
|CS0845|Error|An expression tree lambda may not contain a coalescing operator with a null or default literal left-hand side|
|CS0846|Error|A nested array initializer is expected|
|CS0847|Error|An array initializer of length '{0}' is expected|
|CS0851|Error|Cannot define overloaded constructor '{0}' because it differs from another constructor only on ref and out|
|CS0853|Error|An expression tree may not contain a named argument specification|
|CS0854|Error|An expression tree may not contain a call or invocation that uses optional arguments|
|CS0855|Error|An expression tree may not contain an indexed property|
|CS0856|Error|Indexed property '{0}' has non-optional arguments which must be provided|
|CS0857|Error|Indexed property '{0}' must have all arguments optional|
|CS1001|Error|Identifier expected|
|CS1002|Error|; expected|
|CS1003|Error|Syntax error, '{0}' expected|
|CS1004|Error|Duplicate '{0}' modifier|
|CS1007|Error|Property accessor already defined|
|CS1008|Error|Type byte, sbyte, short, ushort, int, uint, long, or ulong expected|
|CS1009|Error|Unrecognized escape sequence|
|CS1010|Error|Newline in constant|
|CS1011|Error|Empty character literal|
|CS1012|Error|Too many characters in character literal|
|CS1013|Error|Invalid number|
|CS1014|Error|A get or set accessor expected|
|CS1015|Error|An object, string, or class type expected|
|CS1016|Error|Named attribute argument expected|
|CS1017|Error|Catch clauses cannot follow the general catch clause of a try statement|
|CS1018|Error|Keyword 'this' or 'base' expected|
|CS1019|Error|Overloadable unary operator expected|
|CS1020|Error|Overloadable binary operator expected|
|CS1021|Error|Integral constant is too large|
|CS1022|Error|Type or namespace definition, or end-of-file expected|
|CS1023|Error|Embedded statement cannot be a declaration or labeled statement|
|CS1024|Error|Preprocessor directive expected|
|CS1025|Error|Single-line comment or end-of-line expected|
|CS1026|Error|) expected|
|CS1027|Error|#endif directive expected|
|CS1028|Error|Unexpected preprocessor directive|
|CS1029|Error|#error: '{0}'|
|CS1030|Warning|#warning: '{0}'|
|CS1031|Error|Type expected|
|CS1032|Error|Cannot define/undefine preprocessor symbols after first token in file|
|CS1035|Error|End-of-file found, '*/' expected|
|CS1037|Error|Overloadable operator expected|
|CS1038|Error|#endregion directive expected|
|CS1039|Error|Unterminated string literal|
|CS1040|Error|Preprocessor directives must appear as the first non-whitespace character on a line|
|CS1041|Error|Identifier expected; '{1}' is a keyword|
|CS1043|Error|{ or ; expected|
|CS1044|Error|Cannot use more than one type in a for, using, fixed, or declaration statement|
|CS1055|Error|An add or remove accessor expected|
|CS1056|Error|Unexpected character '{0}'|
|CS1057|Error|'{0}': static classes cannot contain protected members|
|CS1058|Warning|A previous catch clause already catches all exceptions. All non-exceptions thrown will be wrapped in a System.Runtime.CompilerServices.RuntimeWrappedException.|
|CS1059|Error|The operand of an increment or decrement operator must be a variable, property or indexer|
|CS1061|Error|'{0}' does not contain a definition for '{1}' and no extension method '{1}' accepting a first argument of type '{0}' could be found (are you missing a using directive or an assembly reference?)|
|CS1062|Warning|The best overloaded Add method '{0}' for the collection initializer element is obsolete. {1}|
|CS1063|Error|The best overloaded Add method '{0}' for the collection initializer element is obsolete. {1}|
|CS1064|Warning|The best overloaded Add method '{0}' for the collection initializer element is obsolete.|
|CS1065|Error|Default values are not valid in this context.|
|CS1066|Warning|The default value specified for parameter '{0}' will have no effect because it applies to a member that is used in contexts that do not allow optional arguments|
|CS1067|Error|Partial declarations of '{0}' must have the same type parameter names and variance modifiers in the same order|
|CS1068|Error|The type name '{0}' could not be found in the global namespace. This type has been forwarded to assembly '{1}' Consider adding a reference to that assembly.|
|CS1069|Error|The type name '{0}' could not be found in the namespace '{1}'. This type has been forwarded to assembly '{2}' Consider adding a reference to that assembly.|
|CS1070|Error|The type name '{0}' could not be found. This type has been forwarded to assembly '{1}'. Consider adding a reference to that assembly.|
|CS1072|Warning|Expected identifier or numeric literal.|
|CS1073|Error|Unexpected token '{0}'|
|CS1100|Error|Method '{0}' has a parameter modifier 'this' which is not on the first parameter|
|CS1101|Error| The parameter modifier 'ref' cannot be used with 'this' |
|CS1102|Error| The parameter modifier 'out' cannot be used with 'this' |
|CS1103|Error|The first parameter of an extension method cannot be of type '{0}'|
|CS1104|Error|A parameter array cannot be used with 'this' modifier on an extension method|
|CS1105|Error|Extension method must be static|
|CS1106|Error|Extension method must be defined in a non-generic static class|
|CS1107|Error|A parameter can only have one '{0}' modifier|
|CS1108|Error|A parameter cannot have all the specified modifiers; there are too many modifiers on the parameter|
|CS1109|Error|Extension methods must be defined in a top level static class; {0} is a nested class|
|CS1110|Error|Cannot define a new extension method because the compiler required type '{0}' cannot be found. Are you missing a reference to System.Core.dll?|
|CS1112|Error|Do not use 'System.Runtime.CompilerServices.ExtensionAttribute'. Use the 'this' keyword instead.|
|CS1113|Error|Extension method '{0}' defined on value type '{1}' cannot be used to create delegates|
|CS1501|Error|No overload for method '{0}' takes {1} arguments|
|CS1503|Error|Argument {0}: cannot convert from '{1}' to '{2}'|
|CS1504|Error|Source file '{0}' could not be opened -- {1}|
|CS1507|Error|Cannot link resource files when building a module|
|CS1508|Error|Resource identifier '{0}' has already been used in this assembly|
|CS1509|Error|The referenced file '{0}' is not an assembly|
|CS1510|Error|A ref or out value must be an assignable variable|
|CS1511|Error|Keyword 'base' is not available in a static method|
|CS1512|Error|Keyword 'base' is not available in the current context|
|CS1513|Error|} expected|
|CS1514|Error|{ expected|
|CS1515|Error|'in' expected|
|CS1517|Error|Invalid preprocessor expression|
|CS1519|Error|Invalid token '{0}' in class, struct, or interface member declaration|
|CS1520|Error|Method must have a return type|
|CS1521|Error|Invalid base type|
|CS1522|Warning|Empty switch block|
|CS1524|Error|Expected catch or finally|
|CS1525|Error|Invalid expression term '{0}'|
|CS1526|Error|A new expression requires (), [], or {} after type|
|CS1527|Error|Elements defined in a namespace cannot be explicitly declared as private, protected, or protected internal|
|CS1528|Error|Expected ; or = (cannot specify constructor arguments in declaration)|
|CS1529|Error|A using clause must precede all other elements defined in the namespace except extern alias declarations|
|CS1534|Error|Overloaded binary operator '{0}' takes two parameters|
|CS1535|Error|Overloaded unary operator '{0}' takes one parameter|
|CS1536|Error|Invalid parameter type 'void'|
|CS1537|Error|The using alias '{0}' appeared previously in this namespace|
|CS1540|Error|Cannot access protected member '{0}' via a qualifier of type '{1}'; the qualifier must be of type '{2}' (or derived from it)|
|CS1542|Error|'{0}' cannot be added to this assembly because it already is an assembly|
|CS1545|Error|Property, indexer, or event '{0}' is not supported by the language; try directly calling accessor methods '{1}' or '{2}'|
|CS1546|Error|Property, indexer, or event '{0}' is not supported by the language; try directly calling accessor method '{1}'|
|CS1547|Error|Keyword 'void' cannot be used in this context|
|CS1551|Error|Indexers must have at least one parameter|
|CS1552|Error|Array type specifier, [], must appear before parameter name|
|CS1553|Error|Declaration is not valid; use '{0} operator <dest-type> (...' instead|
|CS1555|Error|Could not find '{0}' specified for Main method|
|CS1556|Error|'{0}' specified for Main method must be a valid non-generic class or struct|
|CS1558|Error|'{0}' does not have a suitable static Main method|
|CS1562|Error|Outputs without source must have the /out option specified|
|CS1564|Error|Conflicting options specified: Win32 resource file; Win32 manifest|
|CS1565|Error|Conflicting options specified: Win32 resource file; Win32 icon|
|CS1566|Error|Error reading resource '{0}' -- '{1}'|
|CS1569|Error|Error writing to XML documentation file: {0}|
|CS1570|Warning|XML comment has badly formed XML -- '{0}'|
|CS1571|Warning|XML comment has a duplicate param tag for '{0}'|
|CS1572|Warning|XML comment has a param tag for '{0}', but there is no parameter by that name|
|CS1573|Warning|Parameter '{0}' has no matching param tag in the XML comment for '{1}' (but other parameters do)|
|CS1574|Warning|XML comment has cref attribute '{0}' that could not be resolved|
|CS1575|Error|A stackalloc expression requires [] after type|
|CS1576|Error|The line number specified for #line directive is missing or invalid|
|CS1578|Error|Quoted file name, single-line comment or end-of-line expected|
|CS1579|Error|foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public definition for '{1}'|
|CS1580|Warning|Invalid type for parameter {0} in XML comment cref attribute: '{1}'|
|CS1581|Warning|Invalid return type in XML comment cref attribute|
|CS1583|Error|Error reading Win32 resources -- {0}|
|CS1584|Warning|XML comment has syntactically incorrect cref attribute '{0}'|
|CS1585|Error|Member modifier '{0}' must precede the member type and name|
|CS1586|Error|Array creation must have array size or array initializer|
|CS1587|Warning|XML comment is not placed on a valid language element|
|CS1589|Warning|Unable to include XML fragment '{1}' of file '{0}' -- {2}|
|CS1590|Warning|Invalid XML include element -- {0}|
|CS1591|Warning|Missing XML comment for publicly visible type or member '{0}'|
|CS1592|Warning|Badly formed XML in included comments file -- '{0}'|
|CS1593|Error|Delegate '{0}' does not take {1} arguments|
|CS1597|Error|Semicolon after method or accessor block is not valid|
|CS1599|Error|Method or delegate cannot return type '{0}'|
|CS1600|Error|Compilation cancelled by user|
|CS1601|Error|Cannot make reference to variable of type '{0}'|
|CS1604|Error|Cannot assign to '{0}' because it is read-only|
|CS1605|Error|Cannot use '{0}' as a ref or out value because it is read-only|
|CS1607|Warning||
|CS1608|Error|The RequiredAttribute attribute is not permitted on C# types|
|CS1609|Error|Modifiers cannot be placed on event accessor declarations|
|CS1611|Error|The params parameter cannot be declared as ref or out|
|CS1612|Error|Cannot modify the return value of '{0}' because it is not a variable|
|CS1613|Error|The managed coclass wrapper class '{0}' for interface '{1}' cannot be found (are you missing an assembly reference?)|
|CS1614|Error|'{0}' is ambiguous between '{1}' and '{2}'; use either '@{0}' or '{0}Attribute'|
|CS1615|Error|Argument {0} may not be passed with the '{1}' keyword|
|CS1616|Warning|Option '{0}' overrides attribute '{1}' given in a source file or added module|
|CS1617|Error|Invalid option '{0}' for /langversion; must be ISO-1, ISO-2, Default, Latest or a valid version in range 1 to 7.1.|
|CS1618|Error|Cannot create delegate with '{0}' because it or a method it overrides has a Conditional attribute|
|CS1619|Error|Cannot create temporary file -- {0}|
|CS1620|Error|Argument {0} must be passed with the '{1}' keyword|
|CS1621|Error|The yield statement cannot be used inside an anonymous method or lambda expression|
|CS1622|Error|Cannot return a value from an iterator. Use the yield return statement to return a value, or yield break to end the iteration.|
|CS1623|Error|Iterators cannot have ref or out parameters|
|CS1624|Error|The body of '{0}' cannot be an iterator block because '{1}' is not an iterator interface type|
|CS1625|Error|Cannot yield in the body of a finally clause|
|CS1626|Error|Cannot yield a value in the body of a try block with a catch clause|
|CS1627|Error|Expression expected after yield return|
|CS1628|Error|Cannot use ref or out parameter '{0}' inside an anonymous method, lambda expression, or query expression|
|CS1629|Error|Unsafe code may not appear in iterators|
|CS1631|Error|Cannot yield a value in the body of a catch clause|
|CS1632|Error|Control cannot leave the body of an anonymous method or lambda expression|
|CS1633|Warning|Unrecognized #pragma directive|
|CS1634|Warning|Expected disable or restore|
|CS1635|Warning|Cannot restore warning 'CS{0}' because it was disabled globally|
|CS1636|Error|__arglist is not allowed in the parameter list of iterators|
|CS1637|Error|Iterators cannot have unsafe parameters or yield types|
|CS1639|Error|The managed coclass wrapper class signature '{0}' for interface '{1}' is not a valid class name signature|
|CS1640|Error|foreach statement cannot operate on variables of type '{0}' because it implements multiple instantiations of '{1}'; try casting to a specific interface instantiation|
|CS1641|Error|A fixed size buffer field must have the array size specifier after the field name|
|CS1642|Error|Fixed size buffer fields may only be members of structs|
|CS1643|Error|Not all code paths return a value in {0} of type '{1}'|
|CS1645|Warning|Feature '{0}' is not part of the standardized ISO C# language specification, and may not be accepted by other compilers|
|CS1646|Error|Keyword, identifier, or string expected after verbatim specifier: @|
|CS1648|Error|Members of readonly field '{0}' cannot be modified (except in a constructor or a variable initializer)|
|CS1649|Error|Members of readonly field '{0}' cannot be used as a ref or out value (except in a constructor)|
|CS1650|Error|Fields of static readonly field '{0}' cannot be assigned to (except in a static constructor or a variable initializer)|
|CS1651|Error|Fields of static readonly field '{0}' cannot be used as a ref or out value (except in a static constructor)|
|CS1654|Error|Cannot modify members of '{0}' because it is a '{1}'|
|CS1655|Error|Cannot use fields of '{0}' as a ref or out value because it is a '{1}'|
|CS1656|Error|Cannot assign to '{0}' because it is a '{1}'|
|CS1657|Error|Cannot use '{0}' as a ref or out value because it is a '{1}'|
|CS1658|Warning|{0}. See also error CS{1}.|
|CS1660|Error|Cannot convert {0} to type '{1}' because it is not a delegate type|
|CS1661|Error|Cannot convert {0} to delegate type '{1}' because the parameter types do not match the delegate parameter types|
|CS1662|Error|Cannot convert {0} to intended delegate type because some of the return types in the block are not implicitly convertible to the delegate return type|
|CS1663|Error|Fixed size buffer type must be one of the following: bool, byte, short, int, long, char, sbyte, ushort, uint, ulong, float or double|
|CS1664|Error|Fixed size buffer of length {0} and type '{1}' is too big|
|CS1665|Error|Fixed size buffers must have a length greater than zero|
|CS1666|Error|You cannot use fixed size buffers contained in unfixed expressions. Try using the fixed statement.|
|CS1667|Error|Attribute '{0}' is not valid on property or event accessors. It is only valid on '{1}' declarations.|
|CS1668|Warning|Invalid search path '{0}' specified in '{1}' -- '{2}'|
|CS1669|Error|__arglist is not valid in this context|
|CS1670|Error|params is not valid in this context|
|CS1671|Error|A namespace declaration cannot have modifiers or attributes|
|CS1672|Error|Invalid option '{0}' for /platform; must be anycpu, x86, Itanium or x64|
|CS1673|Error|Anonymous methods, lambda expressions, and query expressions inside structs cannot access instance members of 'this'. Consider copying 'this' to a local variable outside the anonymous method, lambda expression or query expression and using the local instead.|
|CS1674|Error|'{0}': type used in a using statement must be implicitly convertible to 'System.IDisposable'|
|CS1676|Error|Parameter {0} must be declared with the '{1}' keyword|
|CS1677|Error|Parameter {0} should not be declared with the '{1}' keyword|
|CS1678|Error|Parameter {0} is declared as type '{1}{2}' but should be '{3}{4}'|
|CS1679|Error|Invalid extern alias for '/reference'; '{0}' is not a valid identifier|
|CS1680|Error|Invalid reference alias option: '{0}=' -- missing filename|
|CS1681|Error|You cannot redefine the global extern alias|
|CS1685|Warning|The predefined type '{0}' is defined in multiple assemblies in the global alias; using definition from '{1}'|
|CS1686|Error|Local '{0}' or its members cannot have their address taken and be used inside an anonymous method or lambda expression|
|CS1687|Warning|Source file has exceeded the limit of 16,707,565 lines representable in the PDB; debug information will be incorrect|
|CS1688|Error|Cannot convert anonymous method block without a parameter list to delegate type '{0}' because it has one or more out parameters|
|CS1689|Error|Attribute '{0}' is only valid on methods or attribute classes|
|CS1690|Warning|Accessing a member on '{0}' may cause a runtime exception because it is a field of a marshal-by-reference class|
|CS1692|Warning|Invalid number|
|CS1695|Warning|Invalid #pragma checksum syntax; should be #pragma checksum "filename" "{XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX}" "XXXX..."|
|CS1696|Warning|Single-line comment or end-of-line expected|
|CS1697|Warning|Different checksum values given for '{0}'|
|CS1700|Warning|Assembly reference '{0}' is invalid and cannot be resolved|
|CS1701|Warning|Assuming assembly reference '{0}' used by '{1}' matches identity '{2}' of '{3}', you may need to supply runtime policy|
|CS1702|Warning|Assuming assembly reference '{0}' used by '{1}' matches identity '{2}' of '{3}', you may need to supply runtime policy|
|CS1703|Error|Multiple assemblies with equivalent identity have been imported: '{0}' and '{1}'. Remove one of the duplicate references.|
|CS1704|Error|An assembly with the same simple name '{0}' has already been imported. Try removing one of the references (e.g. '{1}') or sign them to enable side-by-side.|
|CS1705|Error|Assembly '{0}' with identity '{1}' uses '{2}' which has a higher version than referenced assembly '{3}' with identity '{4}'|
|CS1708|Error|Fixed size buffers can only be accessed through locals or fields|
|CS1710|Warning|XML comment has a duplicate typeparam tag for '{0}'|
|CS1711|Warning|XML comment has a typeparam tag for '{0}', but there is no type parameter by that name|
|CS1712|Warning|Type parameter '{0}' has no matching typeparam tag in the XML comment on '{1}' (but other type parameters do)|
|CS1715|Error|'{0}': type must be '{2}' to match overridden member '{1}'|
|CS1716|Error|Do not use 'System.Runtime.CompilerServices.FixedBuffer' attribute. Use the 'fixed' field modifier instead.|
|CS1717|Warning|Assignment made to same variable; did you mean to assign something else?|
|CS1718|Warning|Comparison made to same variable; did you mean to compare something else?|
|CS1719|Error|Error opening Win32 resource file '{0}' -- '{1}'|
|CS1720|Warning|Expression will always cause a System.NullReferenceException because the default value of '{0}' is null|
|CS1721|Error|Class '{0}' cannot have multiple base classes: '{1}' and '{2}'|
|CS1722|Error|Base class '{0}' must come before any interfaces|
|CS1723|Warning|XML comment has cref attribute '{0}' that refers to a type parameter|
|CS1725|Error|Friend assembly reference '{0}' is invalid. InternalsVisibleTo declarations cannot have a version, culture, public key token, or processor architecture specified.|
|CS1726|Error|Friend assembly reference '{0}' is invalid. Strong-name signed assemblies must specify a public key in their InternalsVisibleTo declarations.|
|CS1728|Error|Cannot bind delegate to '{0}' because it is a member of 'System.Nullable<T>'|
|CS1729|Error|'{0}' does not contain a constructor that takes {1} arguments|
|CS1730|Error|Assembly and module attributes must precede all other elements defined in a file except using clauses and extern alias declarations|
|CS1733|Error|Expected expression|
|CS1734|Warning|XML comment on '{1}' has a paramref tag for '{0}', but there is no parameter by that name|
|CS1735|Warning|XML comment on '{1}' has a typeparamref tag for '{0}', but there is no type parameter by that name|
|CS1736|Error|Default parameter value for '{0}' must be a compile-time constant|
|CS1737|Error|Optional parameters must appear after all required parameters|
|CS1738|Error|Named argument specifications must appear after all fixed arguments have been specified|
|CS1739|Error|The best overload for '{0}' does not have a parameter named '{1}'|
|CS1740|Error|Named argument '{0}' cannot be specified multiple times|
|CS1741|Error|A ref or out parameter cannot have a default value|
|CS1742|Error|An array access may not have a named argument specifier|
|CS1743|Error|Cannot specify a default value for the 'this' parameter|
|CS1744|Error|Named argument '{0}' specifies a parameter for which a positional argument has already been given|
|CS1745|Error|Cannot specify default parameter value in conjunction with DefaultParameterAttribute or OptionalAttribute|
|CS1746|Error|The delegate '{0}' does not have a parameter named '{1}'|
|CS1747|Error|Cannot embed interop types from assembly '{0}' because it is missing the '{1}' attribute.|
|CS1748|Error|Cannot find the interop type that matches the embedded interop type '{0}'. Are you missing an assembly reference?|
|CS1750|Error|A value of type '{0}' cannot be used as a default parameter because there are no standard conversions to type '{1}'|
|CS1751|Error|Cannot specify a default value for a parameter array|
|CS1752|Error|Interop type '{0}' cannot be embedded. Use the applicable interface instead.|
|CS1754|Error|Type '{0}' cannot be embedded because it is a nested type. Consider setting the 'Embed Interop Types' property to false.|
|CS1756|Error|Interop type '{0}' cannot be embedded because it is missing the required '{1}' attribute.|
|CS1757|Error|Embedded interop struct '{0}' can contain only public instance fields.|
|CS1758|Error|Cannot embed interop type '{0}' found in both assembly '{1}' and '{2}'. Consider setting the 'Embed Interop Types' property to false.|
|CS1759|Error|Cannot embed interop types from assembly '{0}' because it is missing either the '{1}' attribute or the '{2}' attribute.|
|CS1760|Error|Assemblies '{0}' and '{1}' refer to the same metadata but only one is a linked reference (specified using /link option); consider removing one of the references.|
|CS1761|Error|Embedding the interop type '{0}' from assembly '{1}' causes a name clash in the current assembly. Consider setting the 'Embed Interop Types' property to false.|
|CS1762|Warning|A reference was created to embedded interop assembly '{0}' because of an indirect reference to that assembly created by assembly '{1}'. Consider changing the 'Embed Interop Types' property on either assembly.|
|CS1763|Error|'{0}' is of type '{1}'. A default parameter value of a reference type other than string can only be initialized with null|
|CS1764|Error|Cannot use fixed local '{0}' inside an anonymous method, lambda expression, or query expression|
|CS1766|Error|Source interface '{0}' is missing method '{1}' which is required to embed event '{2}'.|
|CS1767|Error|Interface '{0}' has an invalid source interface which is required to embed event '{1}'.|
|CS1768|Error|Type '{0}' cannot be embedded because it has a generic argument. Consider setting the 'Embed Interop Types' property to false.|
|CS1769|Error|Type '{0}' from assembly '{1}' cannot be used across assembly boundaries because it has a generic type argument that is an embedded interop type.|
|CS1770|Error|A value of type '{0}' cannot be used as default parameter for nullable parameter '{1}' because '{0}' is not a simple type|
|CS1773|Error|Invalid version {0} for /subsystemversion. The version must be 6.02 or greater for ARM or AppContainerExe, and 4.00 or greater otherwise|
|CS1774|Error|Embedded interop method '{0}' contains a body.|
|CS1900|Error|Warning level must be in the range 0-4|
|CS1902|Error|Invalid option '{0}' for /debug; must be 'portable', 'embedded', 'full' or 'pdbonly'|
|CS1906|Error|Invalid option '{0}'; Resource visibility must be either 'public' or 'private'|
|CS1908|Error|The type of the argument to the DefaultParameterValue attribute must match the parameter type|
|CS1910|Error|Argument of type '{0}' is not applicable for the DefaultParameterValue attribute|
|CS1912|Error|Duplicate initialization of member '{0}'|
|CS1913|Error|Member '{0}' cannot be initialized. It is not a field or property.|
|CS1914|Error|Static field or property '{0}' cannot be assigned in an object initializer|
|CS1917|Error|Members of readonly field '{0}' of type '{1}' cannot be assigned with an object initializer because it is of a value type|
|CS1918|Error|Members of property '{0}' of type '{1}' cannot be assigned with an object initializer because it is of a value type|
|CS1919|Error|Unsafe type '{0}' cannot be used in object creation|
|CS1920|Error|Element initializer cannot be empty|
|CS1921|Error|The best overloaded method match for '{0}' has wrong signature for the initializer element. The initializable Add must be an accessible instance method.|
|CS1922|Error|Cannot initialize type '{0}' with a collection initializer because it does not implement 'System.Collections.IEnumerable'|
|CS1926|Error|Error opening Win32 manifest file {0} -- {1}|
|CS1927|Warning|Ignoring /win32manifest for module because it only applies to assemblies|
|CS1928|Error|'{0}' does not contain a definition for '{1}' and the best extension method overload '{2}' has some invalid arguments|
|CS1929|Error|'{0}' does not contain a definition for '{1}' and the best extension method overload '{2}' requires a receiver of type '{3}'|
|CS1930|Error|The range variable '{0}' has already been declared|
|CS1931|Error|The range variable '{0}' conflicts with a previous declaration of '{0}'|
|CS1932|Error|Cannot assign {0} to a range variable|
|CS1934|Error|Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Consider explicitly specifying the type of the range variable '{2}'.|
|CS1935|Error|Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Are you missing a reference to 'System.Core.dll' or a using directive for 'System.Linq'?|
|CS1936|Error|Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.|
|CS1937|Error|The name '{0}' is not in scope on the left side of 'equals'.  Consider swapping the expressions on either side of 'equals'.|
|CS1938|Error|The name '{0}' is not in scope on the right side of 'equals'.  Consider swapping the expressions on either side of 'equals'.|
|CS1939|Error|Cannot pass the range variable '{0}' as an out or ref parameter|
|CS1940|Error|Multiple implementations of the query pattern were found for source type '{0}'.  Ambiguous call to '{1}'.|
|CS1941|Error|The type of one of the expressions in the {0} clause is incorrect.  Type inference failed in the call to '{1}'.|
|CS1942|Error|The type of the expression in the {0} clause is incorrect.  Type inference failed in the call to '{1}'.|
|CS1943|Error|An expression of type '{0}' is not allowed in a subsequent from clause in a query expression with source type '{1}'.  Type inference failed in the call to '{2}'.|
|CS1944|Error|An expression tree may not contain an unsafe pointer operation|
|CS1945|Error|An expression tree may not contain an anonymous method expression|
|CS1946|Error|An anonymous method expression cannot be converted to an expression tree|
|CS1947|Error|Range variable '{0}' cannot be assigned to -- it is read only|
|CS1948|Error|The range variable '{0}' cannot have the same name as a method type parameter|
|CS1949|Error|The contextual keyword 'var' cannot be used in a range variable declaration|
|CS1950|Error|The best overloaded Add method '{0}' for the collection initializer has some invalid arguments|
|CS1951|Error|An expression tree lambda may not contain an out or ref parameter|
|CS1952|Error|An expression tree lambda may not contain a method with variable arguments|
|CS1954|Error|The best overloaded method match '{0}' for the collection initializer element cannot be used. Collection initializer 'Add' methods cannot have ref or out parameters.|
|CS1955|Error|Non-invocable member '{0}' cannot be used like a method.|
|CS1956|Warning|Member '{0}' implements interface member '{1}' in type '{2}'. There are multiple matches for the interface member at run-time. It is implementation dependent which method will be called.|
|CS1957|Warning|Member '{1}' overrides '{0}'. There are multiple override candidates at run-time. It is implementation dependent which method will be called.|
|CS1958|Error|Object and collection initializer expressions may not be applied to a delegate creation expression|
|CS1959|Error|'{0}' is of type '{1}'. The type specified in a constant declaration must be sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, bool, string, an enum-type, or a reference-type.|
|CS1960|Error|Invalid variance modifier. Only interface and delegate type parameters can be specified as variant.|
|CS1961|Error|Invalid variance: The type parameter '{1}' must be {3} valid on '{0}'. '{1}' is {2}.|
|CS1962|Error|The typeof operator cannot be used on the dynamic type|
|CS1963|Error|An expression tree may not contain a dynamic operation|
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
|CS1983|Error|The return type of an async method must be void, Task or Task<T>|
|CS1984|Error|Cannot await in the body of a finally clause|
|CS1985|Error|Cannot await in a catch clause|
|CS1986|Error|'await' requires that the type {0} have a suitable GetAwaiter method|
|CS1988|Error|Async methods cannot have ref or out parameters|
|CS1989|Error|Async lambda expressions cannot be converted to expression trees|
|CS1991|Error|'{0}' cannot implement '{1}' because '{2}' is a Windows Runtime event and '{3}' is a regular .NET event.|
|CS1992|Error|The 'await' operator can only be used when contained within a method or lambda expression marked with the 'async' modifier|
|CS1994|Error|The 'async' modifier can only be used in methods that have a body.|
|CS1995|Error|The 'await' operator may only be used in a query expression within the first collection expression of the initial 'from' clause or within the collection expression of a 'join' clause|
|CS1996|Error|Cannot await in the body of a lock statement|
|CS1997|Error|Since '{0}' is an async method that returns 'Task', a return keyword must not be followed by an object expression. Did you intend to return 'Task<T>'?|
|CS1998|Warning|This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.|
|CS2001|Error|Source file '{0}' could not be found.|
|CS2002|Warning|Source file '{0}' specified multiple times|
|CS2005|Error|Missing file specification for '{0}' option|
|CS2006|Error|Command-line syntax error: Missing '{0}' for '{1}' option|
|CS2007|Error|Unrecognized option: '{0}'|
|CS2008|Warning|No source files specified.|
|CS2011|Error|Error opening response file '{0}'|
|CS2012|Error|Cannot open '{0}' for writing -- '{1}'|
|CS2013|Error|Invalid image base number '{0}'|
|CS2015|Error|'{0}' is a binary file instead of a text file|
|CS2016|Fatal|Code page '{0}' is invalid or not installed|
|CS2017|Error|Cannot specify /main if building a module or library|
|CS2019|Fatal|Invalid target type for /target: must specify 'exe', 'winexe', 'library', or 'module'|
|CS2021|Fatal|File name '{0}' is empty, contains invalid characters, has a drive specification without an absolute path, or is too long|
|CS2023|Warning|Ignoring /noconfig option because it was specified in a response file|
|CS2024|Error|Invalid file section alignment '{0}'|
|CS2029|Warning|Invalid name for a preprocessing symbol; '{0}' is not a valid identifier|
|CS2033|Fatal|Cannot create short filename '{0}' when a long filename with the same short filename already exists|
|CS2034|Error|A /reference option that declares an extern alias can only have one filename. To specify multiple aliases or filenames, use multiple /reference options.|
|CS2035|Error|Command-line syntax error: Missing ':<number>' for '{0}' option|
|CS2036|Error|The /pdb option requires that the /debug option also be used|
|CS2037|Error|An expression tree lambda may not contain a COM call with ref omitted on arguments|
|CS2038|Warning|The language name '{0}' is invalid.|
|CS2039|Error|Command-line syntax error: Invalid Guid format '{0}' for option '{1}'|
|CS2040|Error|Command-line syntax error: Missing Guid for option '{1}'|
|CS2041|Error|Invalid output name: {0}|
|CS2042|Error|Invalid debug information format: {0}|
|CS2043|Error|'id#' syntax is no longer supported. Use '$id' instead.|
|CS2044|Error|/sourcelink switch is only supported when emitting PDB.|
|CS2045|Error|/embed switch is only supported when emitting Portable PDB (/debug:portable or /debug:embedded).|
|CS3000|Warning|Methods with variable arguments are not CLS-compliant|
|CS3001|Warning|Argument type '{0}' is not CLS-compliant|
|CS3002|Warning|Return type of '{0}' is not CLS-compliant|
|CS3003|Warning|Type of '{0}' is not CLS-compliant|
|CS3005|Warning|Identifier '{0}' differing only in case is not CLS-compliant|
|CS3006|Warning|Overloaded method '{0}' differing only in ref or out, or in array rank, is not CLS-compliant|
|CS3007|Warning|Overloaded method '{0}' differing only by unnamed array types is not CLS-compliant|
|CS3008|Warning|Identifier '{0}' is not CLS-compliant|
|CS3009|Warning|'{0}': base type '{1}' is not CLS-compliant|
|CS3010|Warning|'{0}': CLS-compliant interfaces must have only CLS-compliant members|
|CS3011|Warning|'{0}': only CLS-compliant members can be abstract|
|CS3012|Warning|You must specify the CLSCompliant attribute on the assembly, not the module, to enable CLS compliance checking|
|CS3013|Warning|Added modules must be marked with the CLSCompliant attribute to match the assembly|
|CS3014|Warning|'{0}' cannot be marked as CLS-compliant because the assembly does not have a CLSCompliant attribute|
|CS3015|Warning|'{0}' has no accessible constructors which use only CLS-compliant types|
|CS3016|Warning|Arrays as attribute arguments is not CLS-compliant|
|CS3017|Warning|You cannot specify the CLSCompliant attribute on a module that differs from the CLSCompliant attribute on the assembly|
|CS3018|Warning|'{0}' cannot be marked as CLS-compliant because it is a member of non-CLS-compliant type '{1}'|
|CS3019|Warning|CLS compliance checking will not be performed on '{0}' because it is not visible from outside this assembly|
|CS3021|Warning|'{0}' does not need a CLSCompliant attribute because the assembly does not have a CLSCompliant attribute|
|CS3022|Warning|CLSCompliant attribute has no meaning when applied to parameters. Try putting it on the method instead.|
|CS3023|Warning|CLSCompliant attribute has no meaning when applied to return types. Try putting it on the method instead.|
|CS3024|Warning|Constraint type '{0}' is not CLS-compliant|
|CS3026|Warning|CLS-compliant field '{0}' cannot be volatile|
|CS3027|Warning|'{0}' is not CLS-compliant because base interface '{1}' is not CLS-compliant|
|CS3028|Fatal|Algorithm '{0}' is not supported|
|CS4001|Error|Cannot await '{0}'|
|CS4003|Error|'await' cannot be used as an identifier within an async method or lambda expression|
|CS4004|Error|Cannot await in an unsafe context|
|CS4005|Error|Async methods cannot have unsafe parameters or return types|
|CS4006|Error|__arglist is not allowed in the parameter list of async methods|
|CS4007|Error|'await' cannot be used in an expression containing the type '{0}'|
|CS4008|Error|Cannot await 'void'|
|CS4009|Error|'{0}': an entry point cannot be marked with the 'async' modifier|
|CS4010|Error|Cannot convert async {0} to delegate type '{1}'. An async {0} may return void, Task or Task<T>, none of which are convertible to '{1}'.|
|CS4011|Error|'await' requires that the return type '{0}' of '{1}.GetAwaiter()' have suitable IsCompleted, OnCompleted, and GetResult members, and implement INotifyCompletion or ICriticalNotifyCompletion|
|CS4012|Error|Parameters or locals of type '{0}' cannot be declared in async methods or lambda expressions.|
|CS4013|Error|Instance of type '{0}' cannot be used inside an anonymous function, query expression, iterator block or async method|
|CS4014|Warning|Because this call is not awaited, execution of the current method continues before the call is completed. Consider applying the 'await' operator to the result of the call.|
|CS4015|Error|'MethodImplOptions.Synchronized' cannot be applied to an async method|
|CS4016|Error|Since this is an async method, the return expression must be of type '{0}' rather than 'Task<{0}>'|
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
|CS4028|Error|'await' requires that the type '{0}' have a suitable GetAwaiter method. Are you missing a using directive for 'System'?|
|CS4029|Error|Cannot return an expression of type 'void'|
|CS4030|Error|Security attribute '{0}' cannot be applied to an Async method.|
|CS4031|Error|Async methods are not allowed in an Interface, Class, or Structure which has the 'SecurityCritical' or 'SecuritySafeCritical' attribute.|
|CS4032|Error|The 'await' operator can only be used within an async method. Consider marking this method with the 'async' modifier and changing its return type to 'Task<{0}>'.|
|CS4033|Error|The 'await' operator can only be used within an async method. Consider marking this method with the 'async' modifier and changing its return type to 'Task'.|
|CS4034|Error|The 'await' operator can only be used within an async {0}. Consider marking this {0} with the 'async' modifier.|
|CS4036|Error|'{0}' does not contain a definition for '{1}' and no extension method '{1}' accepting a first argument of type '{0}' could be found (are you missing a using directive for '{2}'?)|
|CS5001|Error|Program does not contain a static 'Main' method suitable for an entry point|
|CS7000|Error|Unexpected use of an aliased name|
|CS7002|Error|Unexpected use of a generic name|
|CS7003|Error|Unexpected use of an unbound generic name|
|CS7006|Error|Expressions and statements can only occur in a method body|
|CS7007|Error|A 'using static' directive can only be applied to types; '{0}' is a namespace not a type. Consider a 'using namespace' directive instead|
|CS7008|Error|The assembly name '{0}' is reserved and cannot be used as a reference in an interactive session|
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
|CS7022|Warning|The entry point of the program is global script code; ignoring '{0}' entry point.|
|CS7023|Error|The second operand of an 'is' or 'as' operator may not be static type '{0}'|
|CS7024|Error|Delegate '{0}' has no invoke method or an invoke method with a return type or parameter types that are not supported.|
|CS7025|Error|Inconsistent accessibility: event type '{1}' is less accessible than event '{0}'|
|CS7026|Error|Assembly and module attributes are not allowed in this context|
|CS7027|Error|Error signing output with public key from file '{0}' -- {1}|
|CS7028|Error|Error signing output with public key from container '{0}' -- {1}|
|CS7029|Error|Friend access was granted by '{0}', but the strong name signing state of the output assembly does not match that of the granting assembly.|
|CS7030|Error|Cannot pass null for friend assembly name|
|CS7032|Error|Key file '{0}' is missing the private key needed for signing|
|CS7033|Warning|Delay signing was specified and requires a public key, but no public key was specified|
|CS7034|Error|The specified version string does not conform to the required format - major[.minor[.build[.revision]]]|
|CS7035|Warning|The specified version string does not conform to the recommended format - major.minor.build.revision|
|CS7036|Error|There is no argument given that corresponds to the required formal parameter '{0}' of '{1}'|
|CS7038|Error|Failed to emit module '{0}'.|
|CS7041|Error|Each linked resource and module must have a unique filename. Filename '{0}' is specified more than once in this assembly|
|CS7042|Error|The DllImport attribute cannot be applied to a method that is generic or contained in a generic type.|
|CS7043|Error|Cannot update '{0}'; attribute '{1}' is missing.|
|CS7045|Error|Parameter not valid for the specified unmanaged type.|
|CS7046|Error|Attribute parameter '{0}' must be specified.|
|CS7047|Error|Attribute parameter '{0}' or '{1}' must be specified.|
|CS7048|Error|First argument to a security attribute must be a valid SecurityAction|
|CS7049|Error|Security attribute '{0}' has an invalid SecurityAction value '{1}'|
|CS7050|Error|SecurityAction value '{0}' is invalid for security attributes applied to an assembly|
|CS7051|Error|SecurityAction value '{0}' is invalid for security attributes applied to a type or a method|
|CS7052|Error|SecurityAction value '{0}' is invalid for PrincipalPermission attribute|
|CS7053|Error|An expression tree may not contain '{0}'|
|CS7054|Error|Unmanaged type '{0}' not valid for fields.|
|CS7055|Error|Unmanaged type '{0}' is only valid for fields.|
|CS7056|Error|Unable to resolve file path '{0}' specified for the named argument '{1}' for PermissionSet attribute|
|CS7057|Error|Error reading file '{0}' specified for the named argument '{1}' for PermissionSet attribute: '{2}'|
|CS7058|Error|The specified version string does not conform to the required format - major.minor.build.revision|
|CS7059|Error|Executables cannot be satellite assemblies; culture should always be empty|
|CS7061|Error|Duplicate '{0}' attribute in '{1}'|
|CS7064|Error|Error opening icon file {0} -- {1}|
|CS7065|Error|Error building Win32 resources -- {0}|
|CS7066|Error|Yield statements may not appear at the top level in interactive code.|
|CS7067|Error|Attribute constructor parameter '{0}' is optional, but no default parameter value was specified.|
|CS7068|Error|Reference to type '{0}' claims it is defined in this assembly, but it is not defined in source or any added modules|
|CS7069|Error|Reference to type '{0}' claims it is defined in '{1}', but it could not be found|
|CS7070|Error|Security attribute '{0}' is not valid on this declaration type. Security attributes are only valid on assembly, type and method declarations.|
|CS7071|Error|Assembly reference '{0}' is invalid and cannot be resolved|
|CS7079|Error|The type '{0}' is defined in a module that has not been added. You must add the module '{1}'.|
|CS7080|Warning|The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerFilePathAttribute.|
|CS7081|Warning|The CallerMemberNameAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.|
|CS7082|Warning|The CallerFilePathAttribute applied to parameter '{0}' will have no effect. It is overridden by the CallerLineNumberAttribute.|
|CS7083|Error|Expression must be implicitly convertible to Boolean or its type '{0}' must define operator '{1}'.|
|CS7084|Error|A Windows Runtime event may not be passed as an out or ref parameter.|
|CS7085|Error|By-reference return type 'ref {0}' is not supported.|
|CS7086|Error|Module name '{0}' stored in '{1}' must match its filename.|
|CS7087|Error|Invalid module name: {0}|
|CS7088|Error|Invalid '{0}' value: '{1}'.|
|CS7089|Error|AppConfigPath must be absolute.|
|CS7090|Warning|Attribute '{0}' from module '{1}' will be ignored in favor of the instance appearing in source|
|CS7091|Error|Attribute '{0}' given in a source file conflicts with option '{1}'.|
|CS7092|Error|A fixed buffer may only have one dimension.|
|CS7093|Error|Cannot read config file '{0}' -- '{1}'|
|CS7094|Error|Cannot await in the filter expression of a catch clause|
|CS7095|Warning|Filter expression is a constant, consider removing the filter|
|CS7096|Error|Cannot continue since the edit includes a reference to an embedded type: '{0}'.|
|CS7098|Error|Linked netmodule metadata must provide a full PE image: '{0}'.|
|CS7099|Error|Metadata references are not supported.|
|CS7100|Error|Assembly culture strings may not contain embedded NUL characters.|
|CS7101|Error|Member '{0}' added during the current debug session can only be accessed from within its declaring assembly '{1}'.|
|CS7102|Error|Compilation options '{0}' and '{1}' can't both be specified at the same time.|
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
|CS8019|Hidden|Unnecessary using directive.|
|CS8020|Hidden|Unused extern alias.|
|CS8021|Warning|No value for RuntimeMetadataVersion found. No assembly containing System.Object was found nor was a value for RuntimeMetadataVersion specified through options.|
|CS8022|Error|Feature '{0}' is not available in C# 1. Please use language version {1} or greater.|
|CS8023|Error|Feature '{0}' is not available in C# 2. Please use language version {1} or greater.|
|CS8024|Error|Feature '{0}' is not available in C# 3. Please use language version {1} or greater.|
|CS8025|Error|Feature '{0}' is not available in C# 4. Please use language version {1} or greater.|
|CS8026|Error|Feature '{0}' is not available in C# 5. Please use language version {1} or greater.|
|CS8027|Error|The field has multiple distinct constant values.|
|CS8028|Error|'{0}': a class with the ComImport attribute cannot specify field initializers.|
|CS8029|Warning|Local name '{0}' is too long for PDB.  Consider shortening or compiling without /debug.|
|CS8030|Error|Anonymous function converted to a void returning delegate cannot return a value|
|CS8031|Error|Async lambda expression converted to a 'Task' returning delegate cannot return a value. Did you intend to return 'Task<T>'?|
|CS8032|Warning|An instance of analyzer {0} cannot be created from {1} : {2}.|
|CS8033|Warning|The assembly {0} does not contain any analyzers.|
|CS8034|Warning|Unable to load Analyzer assembly {0} : {1}|
|CS8035|Error|Error reading ruleset file {0} - {1}|
|CS8036|Error|Error reading debug information for '{0}'|
|CS8040|Info|Skipping some types in analyzer assembly {0} due to a ReflectionTypeLoadException : {1}.|
|CS8050|Error|Only auto-implemented properties can have initializers.|
|CS8051|Error|Auto-implemented properties must have get accessors.|
|CS8052|Error|Auto-implemented properties inside interfaces cannot have initializers.|
|CS8054|Error|Enums cannot contain explicit parameterless constructors|
|CS8055|Error|Cannot emit debug information for a source text without encoding.|
|CS8057|Error|Block bodies and expression bodies cannot both be provided.|
|CS8058|Error|Feature '{0}' is experimental and unsupported; use '/features:{1}' to enable.|
|CS8059|Error|Feature '{0}' is not available in C# 6. Please use language version {1} or greater.|
|CS8070|Error|Control cannot fall out of switch from final case label ('{0}')|
|CS8072|Error|An expression tree lambda may not contain a null propagating operator.|
|CS8073|Warning|The result of the expression is always '{0}' since a value of type '{1}' is never equal to 'null' of type '{2}'|
|CS8074|Error|An expression tree lambda may not contain a dictionary initializer.|
|CS8075|Error|An extension Add method is not supported for a collection initializer in an expression lambda.|
|CS8076|Error|Missing close delimiter '}' for interpolated expression started with '{'.|
|CS8077|Error|A single-line comment may not be used in an interpolated string.|
|CS8078|Error|An expression is too long or complex to compile|
|CS8079|Error|Use of possibly unassigned auto-implemented property '{0}'|
|CS8080|Error|Auto-implemented properties must override all accessors of the overridden property.|
|CS8081|Error|Expression does not have a name.|
|CS8082|Error|Sub-expression cannot be used in an argument to nameof.|
|CS8083|Error|An alias-qualified name is not an expression.|
|CS8084|Error|Type parameters are not allowed on a method group as an argument to 'nameof'.|
|CS8085|Error|A 'using static' directive cannot be used to declare an alias|
|CS8086|Error|A '{0}' character must be escaped (by doubling) in an interpolated string.|
|CS8087|Error|A '{0}' character may only be escaped by doubling '{0}{0}' in an interpolated string.|
|CS8088|Error|A format specifier may not contain trailing whitespace.|
|CS8089|Error|Empty format specifier.|
|CS8090|Error|There is an error in a referenced assembly '{0}'.|
|CS8091|Error|'{0}' cannot be extern and have a constructor initializer|
|CS8092|Error|Expression or declaration statement expected.|
|CS8093|Error|Extension method groups are not allowed as an argument to 'nameof'.|
|CS8094|Warning|Alignment value {0} has a magnitude greater than {1} and may result in a large formatted string.|
|CS8095|Error|Length of String constant exceeds current memory limit.  Try splitting the string into multiple constants.|
|CS8096|Error|Debug entry point must be a definition of a method declared in the current compilation.|
|CS8097|Error|#load is only allowed in scripts|
|CS8098|Error|Cannot use #load after first token in file|
|CS8099|Error|Source file references are not supported.|
|CS8100|Error|The 'await' operator cannot be used in a static script variable initializer.|
|CS8101|Error|The pathmap option was incorrectly formatted.|
|CS8102|Error|Public signing was specified and requires a public key, but no public key was specified.|
|CS8103|Error|Combined length of user strings used by the program exceeds allowed limit. Try to decrease use of string literals.|
|CS8104|Error|An error occurred while writing the output file: {0}.|
|CS8105|Warning|Attribute '{0}' is ignored when public signing is specified.|
|CS8106|Error|Option '{0}' must be an absolute path.|
|CS8107|Error|Feature '{0}' is not available in C# 7. Please use language version {1} or greater.|
|CS8108|Error|Cannot pass argument with dynamic type to params parameter '{0}' of local function '{1}'.|
|CS8110|Error|An expression tree may not contain a reference to a local function|
|CS8111|Error|Invalid instrumentation kind: {0}|
|CS8115|Error|A throw expression is not allowed in this context.|
|CS8116|Error|It is not legal to use nullable type '{0}' in a pattern; use the underlying type '{1}' instead.|
|CS8117|Error|Invalid operand for pattern match; value required, but found '{0}'.|
|CS8119|Error|The switch expression must be a value; found '{0}'.|
|CS8120|Error|The switch case has already been handled by a previous case.|
|CS8121|Error|An expression of type '{0}' cannot be handled by a pattern of type '{1}'.|
|CS8122|Error|An expression tree may not contain an 'is' pattern-matching operator.|
|CS8123|Warning|The tuple element name '{0}' is ignored because a different name or no name is specified by the target type '{1}'.|
|CS8124|Error|Tuple must contain at least two elements.|
|CS8125|Error|Tuple element name '{0}' is only allowed at position {1}.|
|CS8126|Error|Tuple element name '{0}' is disallowed at any position.|
|CS8127|Error|Tuple element names must be unique.|
|CS8128|Error|Member '{0}' was not found on type '{1}' from assembly '{2}'.|
|CS8129|Error|No Deconstruct instance or extension method was found for type '{0}', with {1} out parameters and a void return type.|
|CS8130|Error|Cannot infer the type of implicitly-typed deconstruction variable '{0}'.|
|CS8131|Error|Deconstruct assignment requires an expression with a type on the right-hand-side.|
|CS8132|Error|Cannot deconstruct a tuple of '{0}' elements into '{1}' variables.|
|CS8133|Error|Cannot deconstruct dynamic objects.|
|CS8134|Error|Deconstruction must contain at least two variables.|
|CS8135|Error|Tuple with {0} elements cannot be converted to type '{1}'.|
|CS8136|Error|Deconstruction 'var (...)' form disallows a specific type for 'var'.|
|CS8137|Error|Cannot define a class or member that utilizes tuples because the compiler required type '{0}' cannot be found. Are you missing a reference?|
|CS8138|Error|Cannot reference 'System.Runtime.CompilerServices.TupleElementNamesAttribute' explicitly. Use the tuple syntax to define tuple names.|
|CS8139|Error|'{0}': cannot change tuple element names when overriding inherited member '{1}'|
|CS8140|Error|'{0}' is already listed in the interface list on type '{2}' with different tuple element names, as '{1}'.|
|CS8141|Error|The tuple element names in the signature of method '{0}' must match the tuple element names of interface method '{1}' (including on the return type).|
|CS8142|Error|Both partial method declarations, '{0}' and '{1}', must use the same tuple element names.|
|CS8143|Error|An expression tree may not contain a tuple literal.|
|CS8144|Error|An expression tree may not contain a tuple conversion.|
|CS8145|Error|Auto-implemented properties cannot return by reference|
|CS8146|Error|Properties which return by reference must have a get accessor|
|CS8147|Error|Properties which return by reference cannot have set accessors|
|CS8148|Error|'{0}' must {2}return by reference to match overridden member '{1}'|
|CS8149|Error|By-reference returns may only be used in methods that return by reference|
|CS8150|Error|By-value returns may only be used in methods that return by value|
|CS8151|Error|The return expression must be of type '{0}' because this method returns by reference|
|CS8152|Error|'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}' because it does not return by {3}|
|CS8153|Error|An expression tree lambda may not contain a call to a method, property, or indexer that returns by reference|
|CS8154|Error|The body of '{0}' cannot be an iterator block because '{0}' returns by reference|
|CS8155|Error|Lambda expressions that return by reference cannot be converted to expression trees|
|CS8156|Error|An expression cannot be used in this context because it may not be returned by reference|
|CS8157|Error|Cannot return '{0}' by reference because it was initialized to a value that cannot be returned by reference|
|CS8158|Error|Cannot return by reference a member of '{0}' because it was initialized to a value that cannot be returned by reference|
|CS8159|Error|Cannot return the range variable '{0}' by reference|
|CS8160|Error|A readonly field cannot be returned by reference|
|CS8161|Error|A static readonly field cannot be returned by reference|
|CS8162|Error|Members of readonly field '{0}' cannot be returned by reference|
|CS8163|Error|Fields of static readonly field '{0}' cannot be returned by reference|
|CS8164|Error|Cannot return by reference a result of '{0}' because the argument passed to parameter '{1}' cannot be returned by reference|
|CS8165|Error|Cannot return by reference a member of result of '{0}' because the argument passed to parameter '{1}' cannot be returned by reference|
|CS8166|Error|Cannot return a parameter by reference '{0}' because it is not a ref or out parameter|
|CS8167|Error|Cannot return or a member of parameter '{0}' by reference because it is not a ref or out parameter|
|CS8168|Error|Cannot return local '{0}' by reference because it is not a ref local|
|CS8169|Error|Cannot return a member of local '{0}' by reference because it is not a ref local|
|CS8170|Error|Struct members cannot return 'this' or other instance members by reference|
|CS8171|Error|Cannot initialize a by-value variable with a reference|
|CS8172|Error|Cannot initialize a by-reference variable with a value|
|CS8173|Error|The expression must be of type '{0}' because it is being assigned by reference|
|CS8174|Error|A declaration of a by-reference variable must have an initializer|
|CS8175|Error|Cannot use ref local '{0}' inside an anonymous method, lambda expression, or query expression|
|CS8176|Error|Iterators cannot have by reference locals|
|CS8177|Error|Async methods cannot have by reference locals|
|CS8178|Error|'await' cannot be used in an expression containing a call to '{0}' because it returns by reference|
|CS8179|Error|Predefined type '{0}' is not defined or imported|
|CS8180|Error|{ or ; or => expected|
|CS8181|Error|'new' cannot be used with tuple type. Use a tuple literal expression instead.|
|CS8182|Error|Predefined type '{0}' must be a struct.|
|CS8183|Error|Cannot infer the type of implicitly-typed discard.|
|CS8184|Error|A deconstruction cannot mix declarations and expressions on the left-hand-side.|
|CS8185|Error|A declaration is not allowed in this context.|
|CS8186|Error|A foreach loop must declare its iteration variables.|
|CS8187|Error|Tuple element names are not permitted on the left of a deconstruction.|
|CS8188|Error|An expression tree may not contain a throw-expression.|
|CS8189|Error|Ref mismatch between '{0}' and delegate '{1}'|
|CS8190|Error|Provided source code kind is unsupported or invalid: '{0}'|
|CS8191|Error|Provided documentation mode is unsupported or invalid: '{0}'.|
|CS8192|Error|Provided language version is unsupported or invalid: '{0}'.|
|CS8196|Error|Reference to an implicitly-typed out variable '{0}' is not permitted in the same argument list.|
|CS8197|Error|Cannot infer the type of implicitly-typed out variable '{0}'.|
|CS8198|Error|An expression tree may not contain an out argument variable declaration.|
|CS8199|Error|The syntax 'var (...)' as an lvalue is reserved.|
|CS8200|Error|Out variable and pattern variable declarations are not allowed within constructor initializers, field initializers, or property initializers.|
|CS8201|Error|Out variable and pattern variable declarations are not allowed within a query clause.|
|CS8202|Error|Public signing is not supported for netmodules.|
|CS8203|Error|Invalid assembly name: {0}|
|CS8204|Error|For type '{0}' to be used as an AsyncMethodBuilder for type '{1}', its Task property should return type '{1}' instead of type '{2}'.|
|CS8205|Error|Attributes are not allowed on local function parameters or type parameters|
|CS8206|Error|Module '{0}' in assembly '{1}' is forwarding the type '{2}' to multiple assemblies: '{3}' and '{4}'.|
|CS8207|Error|An expression tree may not contain a discard.|
|CS8208|Error|It is not legal to use the type 'dynamic' in a pattern.|
|CS8209|Error|A value of type 'void' may not be assigned.|
|CS8210|Error|A tuple may not contain a value of type 'void'.|
|CS8300|Error|Merge conflict marker encountered|
|CS8301|Error|Invalid name for a preprocessing symbol; '{0}' is not a valid identifier|
|CS8302|Error|Feature '{0}' is not available in C# 7.1. Please use language version {1} or greater.|
|CS8303|Error|Specified language version '{0}' cannot have leading zeroes|
|CS8304|Error|Compiler version: '{0}'. Language version: {1}.|
|CS8305|Warning|'{0}' is for evaluation purposes only and is subject to change or removal in future updates.|
|CS8306|Error|Tuple element name '{0}' is inferred. Please use language version {1} or greater to access an element by its inferred name.|
|CS8307|Error|The first operand of an 'as' operator may not be a tuple literal without a natural type.|
|CS9000|Error|Cannot use a default literal as an argument to a dynamically dispatched operation.|
|CS9001|Error|Use of default literal is not valid in this context|
|CS9002|Warning|Did you mean to use the default switch label (`default:`) rather than `case default:`? If you really mean to use the default literal, consider `case (default):` or another literal (`case 0:` or `case null:`) as appropriate.|
|CS9003|Error|An expression of type '{0}' cannot be handled by a pattern of type '{1}' in C# {2}. Please use language version {3} or greater.|

## Statistics

|Severity|Count|
|--------|-----|
|Fatal|7|
|Error|1054|
|Warning|169|
|Info|1|
|Hidden|2|
|**Total**|**1235**|
