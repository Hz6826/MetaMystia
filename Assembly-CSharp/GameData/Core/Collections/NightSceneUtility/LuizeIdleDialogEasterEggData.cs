using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000253 RID: 595
	public class LuizeIdleDialogEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06004A27 RID: 18983 RVA: 0x001A1068 File Offset: 0x0019F268
		// Note: this type is marked as 'beforefieldinit'.
		static LuizeIdleDialogEasterEggData()
		{
			Il2CppClassPointerStore<LuizeIdleDialogEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "LuizeIdleDialogEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData>.NativeClassPtr);
			LuizeIdleDialogEasterEggData.NativeFieldInfoPtr_m_PartnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData>.NativeClassPtr, "m_PartnerId");
			LuizeIdleDialogEasterEggData.NativeFieldInfoPtr_IdleDialogTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData>.NativeClassPtr, "IdleDialogTitles");
			LuizeIdleDialogEasterEggData.NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData>.NativeClassPtr, 100678247);
			LuizeIdleDialogEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData>.NativeClassPtr, 100678248);
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x001A10E8 File Offset: 0x0019F2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193849, XrefRangeEnd = 193884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryGetEasterEggIdleDialog(IEnumerable<PartnerBase> partners, out IEnumerable<string> idleDialog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partners);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LuizeIdleDialogEasterEggData.NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			idleDialog = ((intPtr4 == 0) ? null : new IEnumerable<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x001A1164 File Offset: 0x0019F364
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuizeIdleDialogEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuizeIdleDialogEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00025DE2 File Offset: 0x00023FE2
		public LuizeIdleDialogEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x001A11A0 File Offset: 0x0019F3A0
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x00025DEB File Offset: 0x00023FEB
		public unsafe int m_PartnerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuizeIdleDialogEasterEggData.NativeFieldInfoPtr_m_PartnerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuizeIdleDialogEasterEggData.NativeFieldInfoPtr_m_PartnerId)) = value;
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x001A11C8 File Offset: 0x0019F3C8
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x00025E06 File Offset: 0x00024006
		public unsafe Il2CppStringArray IdleDialogTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuizeIdleDialogEasterEggData.NativeFieldInfoPtr_IdleDialogTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LuizeIdleDialogEasterEggData.NativeFieldInfoPtr_IdleDialogTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400330F RID: 13071
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerId;

		// Token: 0x04003310 RID: 13072
		private static readonly IntPtr NativeFieldInfoPtr_IdleDialogTitles;

		// Token: 0x04003311 RID: 13073
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0;

		// Token: 0x04003312 RID: 13074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEF RID: 2799
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.LuizeIdleDialogEasterEggData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D07C RID: 53372 RVA: 0x00333820 File Offset: 0x00331A20
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LuizeIdleDialogEasterEggData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData.__c>.NativeClassPtr);
				LuizeIdleDialogEasterEggData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData.__c>.NativeClassPtr, "<>9");
				LuizeIdleDialogEasterEggData.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData.__c>.NativeClassPtr, "<>9__2_0");
				LuizeIdleDialogEasterEggData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData.__c>.NativeClassPtr, 100678250);
				LuizeIdleDialogEasterEggData.__c.NativeMethodInfoPtr__TryGetEasterEggIdleDialog_b__2_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData.__c>.NativeClassPtr, 100678251);
			}

			// Token: 0x0600D07D RID: 53373 RVA: 0x0033389C File Offset: 0x00331A9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LuizeIdleDialogEasterEggData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuizeIdleDialogEasterEggData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D07E RID: 53374 RVA: 0x003338D8 File Offset: 0x00331AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193848, XrefRangeEnd = 193849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _TryGetEasterEggIdleDialog_b__2_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LuizeIdleDialogEasterEggData.__c.NativeMethodInfoPtr__TryGetEasterEggIdleDialog_b__2_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D07F RID: 53375 RVA: 0x0006FA34 File Offset: 0x0006DC34
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D6 RID: 17366
			// (get) Token: 0x0600D080 RID: 53376 RVA: 0x00333920 File Offset: 0x00331B20
			// (set) Token: 0x0600D081 RID: 53377 RVA: 0x0006FA3D File Offset: 0x0006DC3D
			public unsafe static LuizeIdleDialogEasterEggData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LuizeIdleDialogEasterEggData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuizeIdleDialogEasterEggData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LuizeIdleDialogEasterEggData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D7 RID: 17367
			// (get) Token: 0x0600D082 RID: 53378 RVA: 0x00333948 File Offset: 0x00331B48
			// (set) Token: 0x0600D083 RID: 53379 RVA: 0x0006FA4F File Offset: 0x0006DC4F
			public unsafe static Func<string, string> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LuizeIdleDialogEasterEggData.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LuizeIdleDialogEasterEggData.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008609 RID: 34313
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400860A RID: 34314
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400860B RID: 34315
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400860C RID: 34316
			private static readonly IntPtr NativeMethodInfoPtr__TryGetEasterEggIdleDialog_b__2_0_Internal_String_String_0;
		}
	}
}
