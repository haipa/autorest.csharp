﻿using AutoRest.Core.Extensibility;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.CSharp.eryph.Model;
using AutoRest.CSharp.Model;

namespace AutoRest.CSharp.eryph
{
    public class PluginCsa : Plugin<GeneratorSettingsCs, TransformerCsa, CodeGeneratorCsa, CodeNamerCsa, CodeModelCsa>
    {
        public PluginCsa()
        {
            Context = new DependencyInjection.Context
            {
                // inherit base settings
                Context,

                // set code model implementations our own implementations 
                new Factory<CodeModel, CodeModelCsa>(),
                new Factory<CompositeType, CompositeTypeCsa>(),
                new Factory<DictionaryType, DictionaryTypeCs>(),
                new Factory<EnumType, EnumTypeCs>(),
                new Factory<Method, MethodCsa>(),
                new Factory<MethodGroup, MethodGroupCsa>(),
                new Factory<Parameter, ParameterCs>(),
                new Factory<PrimaryType, PrimaryTypeCs>(),
                new Factory<Property, PropertyCs>(),
                new Factory<SequenceType, SequenceTypeCs>(),

                // we have a specific constructor for when a literal type is necessary.
                new Factory<ILiteralType> {(string name) => new CompositeTypeCsa {Name = {FixedValue = name}}},
            };
        }
    }
}
