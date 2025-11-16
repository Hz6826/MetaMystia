using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;

namespace GameData.Profile
{
	// Token: 0x02000307 RID: 775
	public class SamadhiFireGrill : CookerAssetBase
	{
		// Token: 0x06005CF3 RID: 23795 RVA: 0x001D3AEC File Offset: 0x001D1CEC
		// Note: this type is marked as 'beforefieldinit'.
		static SamadhiFireGrill()
		{
			Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SamadhiFireGrill");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr);
			SamadhiFireGrill.NativeFieldInfoPtr_returnBackRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr, "returnBackRate");
			SamadhiFireGrill.NativeFieldInfoPtr_meatTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr, "meatTag");
			SamadhiFireGrill.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr, 100682472);
			SamadhiFireGrill.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr, 100682473);
			SamadhiFireGrill.NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr, 100682474);
			SamadhiFireGrill.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr, 100682475);
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x001D3B94 File Offset: 0x001D1D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232776, XrefRangeEnd = 232784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SamadhiFireGrill.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x001D3BE8 File Offset: 0x001D1DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232784, XrefRangeEnd = 232787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ExtraCookTimeMultiplier(CookController thisCookController, Sellable food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisCookController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SamadhiFireGrill.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x001D3C54 File Offset: 0x001D1E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232787, XrefRangeEnd = 232845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(finishedFood);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qteScore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref couldReturnIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SamadhiFireGrill.NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x001D3CCC File Offset: 0x001D1ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232845, XrefRangeEnd = 232846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SamadhiFireGrill() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamadhiFireGrill.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x00032BF0 File Offset: 0x00030DF0
		public SamadhiFireGrill(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06005CF9 RID: 23801 RVA: 0x001D3D08 File Offset: 0x001D1F08
		// (set) Token: 0x06005CFA RID: 23802 RVA: 0x00032BF9 File Offset: 0x00030DF9
		public unsafe float returnBackRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamadhiFireGrill.NativeFieldInfoPtr_returnBackRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamadhiFireGrill.NativeFieldInfoPtr_returnBackRate)) = value;
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06005CFB RID: 23803 RVA: 0x001D3D30 File Offset: 0x001D1F30
		// (set) Token: 0x06005CFC RID: 23804 RVA: 0x00032C14 File Offset: 0x00030E14
		public unsafe int meatTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamadhiFireGrill.NativeFieldInfoPtr_meatTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SamadhiFireGrill.NativeFieldInfoPtr_meatTag)) = value;
			}
		}

		// Token: 0x04003D8B RID: 15755
		private static readonly IntPtr NativeFieldInfoPtr_returnBackRate;

		// Token: 0x04003D8C RID: 15756
		private static readonly IntPtr NativeFieldInfoPtr_meatTag;

		// Token: 0x04003D8D RID: 15757
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0;

		// Token: 0x04003D8E RID: 15758
		private static readonly IntPtr NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0;

		// Token: 0x04003D8F RID: 15759
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishCook_Public_Virtual_Sellable_Sellable_Single_Boolean_0;

		// Token: 0x04003D90 RID: 15760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D2C RID: 3372
		[ObfuscatedName("GameData.Profile.SamadhiFireGrill+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600F2F9 RID: 62201 RVA: 0x00398C64 File Offset: 0x00396E64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SamadhiFireGrill>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr);
				SamadhiFireGrill.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr, "<>9");
				SamadhiFireGrill.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr, "<>9__4_0");
				SamadhiFireGrill.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr, "<>9__4_1");
				SamadhiFireGrill.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr, 100682477);
				SamadhiFireGrill.__c.NativeMethodInfoPtr__OnFinishCook_b__4_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr, 100682478);
				SamadhiFireGrill.__c.NativeMethodInfoPtr__OnFinishCook_b__4_1_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr, 100682479);
			}

			// Token: 0x0600F2FA RID: 62202 RVA: 0x00398D08 File Offset: 0x00396F08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SamadhiFireGrill.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamadhiFireGrill.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2FB RID: 62203 RVA: 0x00398D44 File Offset: 0x00396F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnFinishCook_b__4_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamadhiFireGrill.__c.NativeMethodInfoPtr__OnFinishCook_b__4_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2FC RID: 62204 RVA: 0x00398D90 File Offset: 0x00396F90
			[CallerCount(0)]
			public unsafe IEnumerable<int> _OnFinishCook_b__4_1(IEnumerable<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SamadhiFireGrill.__c.NativeMethodInfoPtr__OnFinishCook_b__4_1_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600F2FD RID: 62205 RVA: 0x0008274A File Offset: 0x0008094A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F04 RID: 20228
			// (get) Token: 0x0600F2FE RID: 62206 RVA: 0x00398DE0 File Offset: 0x00396FE0
			// (set) Token: 0x0600F2FF RID: 62207 RVA: 0x00082753 File Offset: 0x00080953
			public unsafe static SamadhiFireGrill.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SamadhiFireGrill.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SamadhiFireGrill.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SamadhiFireGrill.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F05 RID: 20229
			// (get) Token: 0x0600F300 RID: 62208 RVA: 0x00398E08 File Offset: 0x00397008
			// (set) Token: 0x0600F301 RID: 62209 RVA: 0x00082765 File Offset: 0x00080965
			public unsafe static Func<int, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SamadhiFireGrill.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SamadhiFireGrill.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F06 RID: 20230
			// (get) Token: 0x0600F302 RID: 62210 RVA: 0x00398E30 File Offset: 0x00397030
			// (set) Token: 0x0600F303 RID: 62211 RVA: 0x00082777 File Offset: 0x00080977
			public unsafe static Func<IEnumerable<int>, IEnumerable<int>> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SamadhiFireGrill.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SamadhiFireGrill.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009ACA RID: 39626
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009ACB RID: 39627
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04009ACC RID: 39628
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04009ACD RID: 39629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009ACE RID: 39630
			private static readonly IntPtr NativeMethodInfoPtr__OnFinishCook_b__4_0_Internal_Boolean_Int32_0;

			// Token: 0x04009ACF RID: 39631
			private static readonly IntPtr NativeMethodInfoPtr__OnFinishCook_b__4_1_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0;
		}
	}
}
