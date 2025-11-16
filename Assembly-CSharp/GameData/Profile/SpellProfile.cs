using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000318 RID: 792
	public class SpellProfile : ScriptableObject
	{
		// Token: 0x06005E19 RID: 24089 RVA: 0x001D7558 File Offset: 0x001D5758
		// Note: this type is marked as 'beforefieldinit'.
		static SpellProfile()
		{
			Il2CppClassPointerStore<SpellProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SpellProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellProfile>.NativeClassPtr);
			SpellProfile.NativeFieldInfoPtr_spells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellProfile>.NativeClassPtr, "spells");
			SpellProfile.NativeFieldInfoPtr_previewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellProfile>.NativeClassPtr, "previewName");
			SpellProfile.NativeFieldInfoPtr_languageRaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellProfile>.NativeClassPtr, "languageRaw");
			SpellProfile.NativeMethodInfoPtr_get_Spells_Public_get_IEnumerable_1_SpellIdPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellProfile>.NativeClassPtr, 100682622);
			SpellProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellProfile>.NativeClassPtr, 100682623);
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06005E1A RID: 24090 RVA: 0x001D75EC File Offset: 0x001D57EC
		public unsafe IEnumerable<SpellIdPair> Spells
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellProfile.NativeMethodInfoPtr_get_Spells_Public_get_IEnumerable_1_SpellIdPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SpellIdPair>>(intPtr3) : null;
			}
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x001D762C File Offset: 0x001D582C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x000334A4 File Offset: 0x000316A4
		public SpellProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06005E1D RID: 24093 RVA: 0x001D7668 File Offset: 0x001D5868
		// (set) Token: 0x06005E1E RID: 24094 RVA: 0x000334AD File Offset: 0x000316AD
		public unsafe Il2CppReferenceArray<SpellIdPair> spells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellProfile.NativeFieldInfoPtr_spells);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpellIdPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellProfile.NativeFieldInfoPtr_spells), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06005E1F RID: 24095 RVA: 0x001D7698 File Offset: 0x001D5898
		// (set) Token: 0x06005E20 RID: 24096 RVA: 0x000334CC File Offset: 0x000316CC
		public unsafe string previewName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellProfile.NativeFieldInfoPtr_previewName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellProfile.NativeFieldInfoPtr_previewName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06005E21 RID: 24097 RVA: 0x001D76C0 File Offset: 0x001D58C0
		// (set) Token: 0x06005E22 RID: 24098 RVA: 0x000334EB File Offset: 0x000316EB
		public unsafe TextAsset languageRaw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellProfile.NativeFieldInfoPtr_languageRaw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellProfile.NativeFieldInfoPtr_languageRaw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E45 RID: 15941
		private static readonly IntPtr NativeFieldInfoPtr_spells;

		// Token: 0x04003E46 RID: 15942
		private static readonly IntPtr NativeFieldInfoPtr_previewName;

		// Token: 0x04003E47 RID: 15943
		private static readonly IntPtr NativeFieldInfoPtr_languageRaw;

		// Token: 0x04003E48 RID: 15944
		private static readonly IntPtr NativeMethodInfoPtr_get_Spells_Public_get_IEnumerable_1_SpellIdPair_0;

		// Token: 0x04003E49 RID: 15945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
