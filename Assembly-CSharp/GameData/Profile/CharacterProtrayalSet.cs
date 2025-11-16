using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002C7 RID: 711
	public class CharacterProtrayalSet : ScriptableObject
	{
		// Token: 0x06005856 RID: 22614 RVA: 0x001C843C File Offset: 0x001C663C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterProtrayalSet()
		{
			Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CharacterProtrayalSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr);
			CharacterProtrayalSet.NativeFieldInfoPtr_defaultPortrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr, "defaultPortrayal");
			CharacterProtrayalSet.NativeFieldInfoPtr_explicitPortrayals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr, "explicitPortrayals");
			CharacterProtrayalSet.NativeFieldInfoPtr_dlcPortrayals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr, "dlcPortrayals");
			CharacterProtrayalSet.NativeMethodInfoPtr_GetProtrayal_Public_CharacterPortrayal_SkinSelectionInfo_Nullable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr, 100681250);
			CharacterProtrayalSet.NativeMethodInfoPtr_GetDefaultProtrayal_Public_CharacterPortrayal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr, 100681251);
			CharacterProtrayalSet.NativeMethodInfoPtr_GetDefaultWorkProtrayal_Public_CharacterPortrayal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr, 100681252);
			CharacterProtrayalSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr, 100681253);
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x001C84F8 File Offset: 0x001C66F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218705, RefRangeEnd = 218707, XrefRangeStart = 218698, XrefRangeEnd = 218705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterPortrayal GetProtrayal(CharacterSkinSets.SkinSelectionInfo selectionInfo, Nullable<int> overrideIndex, bool useDefaultSkin = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionInfo;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideIndex));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDefaultSkin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterProtrayalSet.NativeMethodInfoPtr_GetProtrayal_Public_CharacterPortrayal_SkinSelectionInfo_Nullable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x001C856C File Offset: 0x001C676C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218712, RefRangeEnd = 218713, XrefRangeStart = 218707, XrefRangeEnd = 218712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterPortrayal GetDefaultProtrayal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterProtrayalSet.NativeMethodInfoPtr_GetDefaultProtrayal_Public_CharacterPortrayal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x001C85AC File Offset: 0x001C67AC
		[CallerCount(0)]
		public unsafe CharacterPortrayal GetDefaultWorkProtrayal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterProtrayalSet.NativeMethodInfoPtr_GetDefaultWorkProtrayal_Public_CharacterPortrayal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x001C85EC File Offset: 0x001C67EC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterProtrayalSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterProtrayalSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterProtrayalSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x0002F57B File Offset: 0x0002D77B
		public CharacterProtrayalSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x0600585C RID: 22620 RVA: 0x001C8628 File Offset: 0x001C6828
		// (set) Token: 0x0600585D RID: 22621 RVA: 0x0002F584 File Offset: 0x0002D784
		public unsafe CharacterPortrayal defaultPortrayal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterProtrayalSet.NativeFieldInfoPtr_defaultPortrayal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterProtrayalSet.NativeFieldInfoPtr_defaultPortrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x0600585E RID: 22622 RVA: 0x001C8658 File Offset: 0x001C6858
		// (set) Token: 0x0600585F RID: 22623 RVA: 0x0002F5A3 File Offset: 0x0002D7A3
		public unsafe Il2CppReferenceArray<CharacterPortrayal> explicitPortrayals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterProtrayalSet.NativeFieldInfoPtr_explicitPortrayals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterPortrayal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterProtrayalSet.NativeFieldInfoPtr_explicitPortrayals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06005860 RID: 22624 RVA: 0x001C8688 File Offset: 0x001C6888
		// (set) Token: 0x06005861 RID: 22625 RVA: 0x0002F5C2 File Offset: 0x0002D7C2
		public unsafe Il2CppReferenceArray<CharacterPortrayal> dlcPortrayals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterProtrayalSet.NativeFieldInfoPtr_dlcPortrayals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterPortrayal>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterProtrayalSet.NativeFieldInfoPtr_dlcPortrayals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B2D RID: 15149
		private static readonly IntPtr NativeFieldInfoPtr_defaultPortrayal;

		// Token: 0x04003B2E RID: 15150
		private static readonly IntPtr NativeFieldInfoPtr_explicitPortrayals;

		// Token: 0x04003B2F RID: 15151
		private static readonly IntPtr NativeFieldInfoPtr_dlcPortrayals;

		// Token: 0x04003B30 RID: 15152
		private static readonly IntPtr NativeMethodInfoPtr_GetProtrayal_Public_CharacterPortrayal_SkinSelectionInfo_Nullable_1_Int32_Boolean_0;

		// Token: 0x04003B31 RID: 15153
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProtrayal_Public_CharacterPortrayal_0;

		// Token: 0x04003B32 RID: 15154
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultWorkProtrayal_Public_CharacterPortrayal_0;

		// Token: 0x04003B33 RID: 15155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
