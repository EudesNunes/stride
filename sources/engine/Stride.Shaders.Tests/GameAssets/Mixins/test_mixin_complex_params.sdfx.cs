﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Test1
{
    [DataContract]public partial class SubParameters : ShaderMixinParameters
    {
        public static readonly PermutationParameterKey<bool> param1 = ParameterKeys.NewPermutation<bool>();
        public static readonly PermutationParameterKey<int> param2 = ParameterKeys.NewPermutation<int>(1);
        public static readonly PermutationParameterKey<string> param3 = ParameterKeys.NewPermutation<string>("ok");
    };
    [DataContract]public partial class TestParameters : ShaderMixinParameters
    {
        public static readonly PermutationParameterKey<SubParameters> subParam1 = ParameterKeys.NewPermutation<SubParameters>();
        public static readonly PermutationParameterKey<SubParameters[]> subParameters = ParameterKeys.NewPermutation<SubParameters[]>();
    };
    internal static partial class ShaderMixins
    {
        internal partial class DefaultComplexParams  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "A");
                context.Mixin(mixin, "B");
                context.Mixin(mixin, "C");
                int x = 1;
                foreach(var ____1 in context.GetParam(TestParameters.subParameters))

                {
                    context.PushParameters(____1);
                    if (context.GetParam(SubParameters.param1))
                    {
                        context.Mixin(mixin, "C" + x);
                    }
                    x++;
                    context.PopParameters();
                }

                {
                    context.PushParameters(context.GetParam(TestParameters.subParam1));
                    if (context.GetParam(SubParameters.param2) == 1)
                    {
                        context.Mixin(mixin, "D");
                    }
                    context.PopParameters();
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("DefaultComplexParams", new DefaultComplexParams());
            }
        }
    }
}