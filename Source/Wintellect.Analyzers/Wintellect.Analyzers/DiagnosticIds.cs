﻿/*------------------------------------------------------------------------------
Wintellect.Analyzers - .NET Compiler Platform ("Roslyn") Analyzers and CodeFixes
Copyright (c) Wintellect. All rights reserved
Licensed under the MIT license
------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wintellect.Analyzers
{
    /// <summary>
    /// The only class that holds the actual analyzer IDs. When creating new rules, 
    /// put the ID constants in here to avoid number conflicts.
    /// </summary>
    static internal class DiagnosticIds
    {
        public const String ReturningTaskRequiresAsyncAnalyzer = "Wintellect001";
        public const String CallAssertMethodsWithMessageParameterAnalyzer = "Wintellect002";
        public const String IfAndElseMustHaveBracesAnalyzer = "Wintellect003";
        public const String AvoidPreDefinedTypesAnalyzer = "Wintellect004";
        public const String AvoidCallingMethodsWithParamArgsAnalyzer = "Wintellect005";
    }
}