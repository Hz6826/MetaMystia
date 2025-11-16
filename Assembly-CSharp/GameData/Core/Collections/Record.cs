using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections
{
	// Token: 0x02000243 RID: 579
	[Serializable]
	public class Record : Item
	{
		// Token: 0x06004835 RID: 18485 RVA: 0x00198B50 File Offset: 0x00196D50
		// Note: this type is marked as 'beforefieldinit'.
		static Record()
		{
			Il2CppClassPointerStore<Record>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Record");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Record>.NativeClassPtr);
			Record.NativeFieldInfoPtr_nameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Record>.NativeClassPtr, "nameKey");
			Record.NativeFieldInfoPtr_targetBGMReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Record>.NativeClassPtr, "targetBGMReference");
			Record.NativeFieldInfoPtr_selectedImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Record>.NativeClassPtr, "selectedImage");
			Record.NativeFieldInfoPtr_deselectedImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Record>.NativeClassPtr, "deselectedImage");
			Record.NativeFieldInfoPtr_IzakayaMusicPackageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Record>.NativeClassPtr, "IzakayaMusicPackageIndex");
			Record.NativeFieldInfoPtr_IzakayaMusicIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Record>.NativeClassPtr, "IzakayaMusicIndex");
			Record.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_AssetReference_KeyValuePair_2_Sprite_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677735);
			Record.NativeMethodInfoPtr_get_NameKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677736);
			Record.NativeMethodInfoPtr_set_NameKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677737);
			Record.NativeMethodInfoPtr_get_TargetBGMReference_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677738);
			Record.NativeMethodInfoPtr_set_TargetBGMReference_Public_set_Void_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677739);
			Record.NativeMethodInfoPtr_get_PlayerImage_Public_get_KeyValuePair_2_Sprite_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677740);
			Record.NativeMethodInfoPtr_set_PlayerImage_Public_set_Void_KeyValuePair_2_Sprite_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677741);
			Record.NativeMethodInfoPtr_SetImage_Private_Void_KeyValuePair_2_Sprite_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677742);
			Record.NativeMethodInfoPtr_GetIzakayaMusicPackageIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677743);
			Record.NativeMethodInfoPtr_GetIzakayaMusicIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Record>.NativeClassPtr, 100677744);
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x00198CC0 File Offset: 0x00196EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189958, XrefRangeEnd = 189965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Record(int id, string nameKey, AssetReference targetBGMReference, KeyValuePair<Sprite, Sprite> playerImage) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Record>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetBGMReference);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(playerImage));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_AssetReference_KeyValuePair_2_Sprite_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x00198D44 File Offset: 0x00196F44
		// (set) Token: 0x06004838 RID: 18488 RVA: 0x00198D7C File Offset: 0x00196F7C
		public unsafe string NameKey
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_get_NameKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_set_NameKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06004839 RID: 18489 RVA: 0x00198DC0 File Offset: 0x00196FC0
		// (set) Token: 0x0600483A RID: 18490 RVA: 0x00198E00 File Offset: 0x00197000
		public unsafe AssetReference TargetBGMReference
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_get_TargetBGMReference_Public_get_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_set_TargetBGMReference_Public_set_Void_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x00198E44 File Offset: 0x00197044
		// (set) Token: 0x0600483C RID: 18492 RVA: 0x00198E7C File Offset: 0x0019707C
		public unsafe KeyValuePair<Sprite, Sprite> PlayerImage
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 189968, RefRangeEnd = 189970, XrefRangeStart = 189965, XrefRangeEnd = 189968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_get_PlayerImage_Public_get_KeyValuePair_2_Sprite_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<Sprite, Sprite>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189970, XrefRangeEnd = 189974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_set_PlayerImage_Public_set_Void_KeyValuePair_2_Sprite_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x00198EC4 File Offset: 0x001970C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189974, XrefRangeEnd = 189978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImage(KeyValuePair<Sprite, Sprite> valuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(valuePair));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_SetImage_Private_Void_KeyValuePair_2_Sprite_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x00198F0C File Offset: 0x0019710C
		[CallerCount(0)]
		public unsafe int GetIzakayaMusicPackageIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_GetIzakayaMusicPackageIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x00198F48 File Offset: 0x00197148
		[CallerCount(0)]
		public unsafe int GetIzakayaMusicIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Record.NativeMethodInfoPtr_GetIzakayaMusicIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x00025214 File Offset: 0x00023414
		public Record(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06004841 RID: 18497 RVA: 0x00198F84 File Offset: 0x00197184
		// (set) Token: 0x06004842 RID: 18498 RVA: 0x0002521D File Offset: 0x0002341D
		public unsafe string nameKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_nameKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_nameKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06004843 RID: 18499 RVA: 0x00198FAC File Offset: 0x001971AC
		// (set) Token: 0x06004844 RID: 18500 RVA: 0x0002523C File Offset: 0x0002343C
		public unsafe AssetReference targetBGMReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_targetBGMReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_targetBGMReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x00198FDC File Offset: 0x001971DC
		// (set) Token: 0x06004846 RID: 18502 RVA: 0x0002525B File Offset: 0x0002345B
		public unsafe Sprite selectedImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_selectedImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_selectedImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x0019900C File Offset: 0x0019720C
		// (set) Token: 0x06004848 RID: 18504 RVA: 0x0002527A File Offset: 0x0002347A
		public unsafe Sprite deselectedImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_deselectedImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_deselectedImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x0019903C File Offset: 0x0019723C
		// (set) Token: 0x0600484A RID: 18506 RVA: 0x00025299 File Offset: 0x00023499
		public unsafe int IzakayaMusicPackageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_IzakayaMusicPackageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_IzakayaMusicPackageIndex)) = value;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x00199064 File Offset: 0x00197264
		// (set) Token: 0x0600484C RID: 18508 RVA: 0x000252B4 File Offset: 0x000234B4
		public unsafe int IzakayaMusicIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_IzakayaMusicIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Record.NativeFieldInfoPtr_IzakayaMusicIndex)) = value;
			}
		}

		// Token: 0x04003198 RID: 12696
		private static readonly IntPtr NativeFieldInfoPtr_nameKey;

		// Token: 0x04003199 RID: 12697
		private static readonly IntPtr NativeFieldInfoPtr_targetBGMReference;

		// Token: 0x0400319A RID: 12698
		private static readonly IntPtr NativeFieldInfoPtr_selectedImage;

		// Token: 0x0400319B RID: 12699
		private static readonly IntPtr NativeFieldInfoPtr_deselectedImage;

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaMusicPackageIndex;

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeFieldInfoPtr_IzakayaMusicIndex;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_AssetReference_KeyValuePair_2_Sprite_Sprite_0;

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeMethodInfoPtr_get_NameKey_Public_get_String_0;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeMethodInfoPtr_set_NameKey_Public_set_Void_String_0;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetBGMReference_Public_get_AssetReference_0;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetBGMReference_Public_set_Void_AssetReference_0;

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerImage_Public_get_KeyValuePair_2_Sprite_Sprite_0;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerImage_Public_set_Void_KeyValuePair_2_Sprite_Sprite_0;

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeMethodInfoPtr_SetImage_Private_Void_KeyValuePair_2_Sprite_Sprite_0;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayaMusicPackageIndex_Public_Int32_0;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeMethodInfoPtr_GetIzakayaMusicIndex_Public_Int32_0;
	}
}
