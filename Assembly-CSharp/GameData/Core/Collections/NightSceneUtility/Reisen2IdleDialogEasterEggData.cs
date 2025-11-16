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
	// Token: 0x02000259 RID: 601
	public class Reisen2IdleDialogEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06004A48 RID: 19016 RVA: 0x001A18D4 File Offset: 0x0019FAD4
		// Note: this type is marked as 'beforefieldinit'.
		static Reisen2IdleDialogEasterEggData()
		{
			Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "Reisen2IdleDialogEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData>.NativeClassPtr);
			Reisen2IdleDialogEasterEggData.NativeFieldInfoPtr_m_PartnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData>.NativeClassPtr, "m_PartnerId");
			Reisen2IdleDialogEasterEggData.NativeFieldInfoPtr_IdleDialogTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData>.NativeClassPtr, "IdleDialogTitles");
			Reisen2IdleDialogEasterEggData.NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData>.NativeClassPtr, 100678263);
			Reisen2IdleDialogEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData>.NativeClassPtr, 100678264);
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x001A1954 File Offset: 0x0019FB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193964, XrefRangeEnd = 193999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryGetEasterEggIdleDialog(IEnumerable<PartnerBase> partners, out IEnumerable<string> idleDialog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partners);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Reisen2IdleDialogEasterEggData.NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			idleDialog = ((intPtr4 == 0) ? null : new IEnumerable<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x001A19D0 File Offset: 0x0019FBD0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Reisen2IdleDialogEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reisen2IdleDialogEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x00025E88 File Offset: 0x00024088
		public Reisen2IdleDialogEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x001A1A0C File Offset: 0x0019FC0C
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x00025E91 File Offset: 0x00024091
		public unsafe int m_PartnerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reisen2IdleDialogEasterEggData.NativeFieldInfoPtr_m_PartnerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reisen2IdleDialogEasterEggData.NativeFieldInfoPtr_m_PartnerId)) = value;
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x001A1A34 File Offset: 0x0019FC34
		// (set) Token: 0x06004A4F RID: 19023 RVA: 0x00025EAC File Offset: 0x000240AC
		public unsafe Il2CppStringArray IdleDialogTitles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reisen2IdleDialogEasterEggData.NativeFieldInfoPtr_IdleDialogTitles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Reisen2IdleDialogEasterEggData.NativeFieldInfoPtr_IdleDialogTitles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003320 RID: 13088
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerId;

		// Token: 0x04003321 RID: 13089
		private static readonly IntPtr NativeFieldInfoPtr_IdleDialogTitles;

		// Token: 0x04003322 RID: 13090
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0;

		// Token: 0x04003323 RID: 13091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF0 RID: 2800
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.Reisen2IdleDialogEasterEggData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600D084 RID: 53380 RVA: 0x00333970 File Offset: 0x00331B70
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData.__c>.NativeClassPtr);
				Reisen2IdleDialogEasterEggData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData.__c>.NativeClassPtr, "<>9");
				Reisen2IdleDialogEasterEggData.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData.__c>.NativeClassPtr, "<>9__2_0");
				Reisen2IdleDialogEasterEggData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData.__c>.NativeClassPtr, 100678266);
				Reisen2IdleDialogEasterEggData.__c.NativeMethodInfoPtr__TryGetEasterEggIdleDialog_b__2_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData.__c>.NativeClassPtr, 100678267);
			}

			// Token: 0x0600D085 RID: 53381 RVA: 0x003339EC File Offset: 0x00331BEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Reisen2IdleDialogEasterEggData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reisen2IdleDialogEasterEggData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D086 RID: 53382 RVA: 0x00333A28 File Offset: 0x00331C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _TryGetEasterEggIdleDialog_b__2_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Reisen2IdleDialogEasterEggData.__c.NativeMethodInfoPtr__TryGetEasterEggIdleDialog_b__2_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D087 RID: 53383 RVA: 0x0006FA61 File Offset: 0x0006DC61
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D8 RID: 17368
			// (get) Token: 0x0600D088 RID: 53384 RVA: 0x00333A70 File Offset: 0x00331C70
			// (set) Token: 0x0600D089 RID: 53385 RVA: 0x0006FA6A File Offset: 0x0006DC6A
			public unsafe static Reisen2IdleDialogEasterEggData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Reisen2IdleDialogEasterEggData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Reisen2IdleDialogEasterEggData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Reisen2IdleDialogEasterEggData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D9 RID: 17369
			// (get) Token: 0x0600D08A RID: 53386 RVA: 0x00333A98 File Offset: 0x00331C98
			// (set) Token: 0x0600D08B RID: 53387 RVA: 0x0006FA7C File Offset: 0x0006DC7C
			public unsafe static Func<string, string> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Reisen2IdleDialogEasterEggData.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Reisen2IdleDialogEasterEggData.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400860D RID: 34317
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400860E RID: 34318
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400860F RID: 34319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008610 RID: 34320
			private static readonly IntPtr NativeMethodInfoPtr__TryGetEasterEggIdleDialog_b__2_0_Internal_String_String_0;
		}
	}
}
