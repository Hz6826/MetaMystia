using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x0200023E RID: 574
	[Serializable]
	public class Decoration : Item
	{
		// Token: 0x060047B7 RID: 18359 RVA: 0x00196DC4 File Offset: 0x00194FC4
		// Note: this type is marked as 'beforefieldinit'.
		static Decoration()
		{
			Il2CppClassPointerStore<Decoration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Decoration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decoration>.NativeClassPtr);
			Decoration.NativeFieldInfoPtr_overrideSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoration>.NativeClassPtr, "overrideSprite");
			Decoration.NativeFieldInfoPtr_specialBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoration>.NativeClassPtr, "specialBuff");
			Decoration.NativeFieldInfoPtr_decorationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoration>.NativeClassPtr, "decorationType");
			Decoration.NativeFieldInfoPtr_conflictDecorationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoration>.NativeClassPtr, "conflictDecorationId");
			Decoration.NativeMethodInfoPtr__ctor_Public_Void_Int32_Sprite_DecorationBase_DecorationType_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoration>.NativeClassPtr, 100677651);
			Decoration.NativeMethodInfoPtr_get_OverrideSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoration>.NativeClassPtr, 100677652);
			Decoration.NativeMethodInfoPtr_set_OverrideSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoration>.NativeClassPtr, 100677653);
			Decoration.NativeMethodInfoPtr_get_SpecialBuff_Public_get_DecorationBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoration>.NativeClassPtr, 100677654);
			Decoration.NativeMethodInfoPtr_get_DecorationSettingType_Public_get_DecorationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoration>.NativeClassPtr, 100677655);
			Decoration.NativeMethodInfoPtr_get_ConflictDecorationId_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoration>.NativeClassPtr, 100677656);
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x00196EBC File Offset: 0x001950BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189515, XrefRangeEnd = 189519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decoration(int id, Sprite overrideSprite, DecorationBase specialBuff, Decoration.DecorationType decorationType, Il2CppStructArray<int> conflictDecorationId) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Decoration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideSprite);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialBuff);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decorationType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conflictDecorationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoration.NativeMethodInfoPtr__ctor_Public_Void_Int32_Sprite_DecorationBase_DecorationType_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x00196F48 File Offset: 0x00195148
		// (set) Token: 0x060047BA RID: 18362 RVA: 0x00196F88 File Offset: 0x00195188
		public unsafe Sprite OverrideSprite
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoration.NativeMethodInfoPtr_get_OverrideSprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoration.NativeMethodInfoPtr_set_OverrideSprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x060047BB RID: 18363 RVA: 0x00196FCC File Offset: 0x001951CC
		public unsafe DecorationBase SpecialBuff
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoration.NativeMethodInfoPtr_get_SpecialBuff_Public_get_DecorationBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecorationBase>(intPtr3) : null;
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x060047BC RID: 18364 RVA: 0x0019700C File Offset: 0x0019520C
		public unsafe Decoration.DecorationType DecorationSettingType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49351, RefRangeEnd = 49352, XrefRangeStart = 49351, XrefRangeEnd = 49352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoration.NativeMethodInfoPtr_get_DecorationSettingType_Public_get_DecorationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x00197048 File Offset: 0x00195248
		public unsafe Il2CppStructArray<int> ConflictDecorationId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 189522, RefRangeEnd = 189523, XrefRangeStart = 189519, XrefRangeEnd = 189522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoration.NativeMethodInfoPtr_get_ConflictDecorationId_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x00024F11 File Offset: 0x00023111
		public Decoration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x060047BF RID: 18367 RVA: 0x00197088 File Offset: 0x00195288
		// (set) Token: 0x060047C0 RID: 18368 RVA: 0x00024F1A File Offset: 0x0002311A
		public unsafe Sprite overrideSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoration.NativeFieldInfoPtr_overrideSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoration.NativeFieldInfoPtr_overrideSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x060047C1 RID: 18369 RVA: 0x001970B8 File Offset: 0x001952B8
		// (set) Token: 0x060047C2 RID: 18370 RVA: 0x00024F39 File Offset: 0x00023139
		public unsafe DecorationBase specialBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoration.NativeFieldInfoPtr_specialBuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecorationBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoration.NativeFieldInfoPtr_specialBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x060047C3 RID: 18371 RVA: 0x001970E8 File Offset: 0x001952E8
		// (set) Token: 0x060047C4 RID: 18372 RVA: 0x00024F58 File Offset: 0x00023158
		public unsafe Decoration.DecorationType decorationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoration.NativeFieldInfoPtr_decorationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoration.NativeFieldInfoPtr_decorationType)) = value;
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x060047C5 RID: 18373 RVA: 0x00197110 File Offset: 0x00195310
		// (set) Token: 0x060047C6 RID: 18374 RVA: 0x00024F73 File Offset: 0x00023173
		public unsafe Il2CppStructArray<int> conflictDecorationId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoration.NativeFieldInfoPtr_conflictDecorationId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoration.NativeFieldInfoPtr_conflictDecorationId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeFieldInfoPtr_overrideSprite;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeFieldInfoPtr_specialBuff;

		// Token: 0x04003141 RID: 12609
		private static readonly IntPtr NativeFieldInfoPtr_decorationType;

		// Token: 0x04003142 RID: 12610
		private static readonly IntPtr NativeFieldInfoPtr_conflictDecorationId;

		// Token: 0x04003143 RID: 12611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Sprite_DecorationBase_DecorationType_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003144 RID: 12612
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideSprite_Public_get_Sprite_0;

		// Token: 0x04003145 RID: 12613
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideSprite_Public_set_Void_Sprite_0;

		// Token: 0x04003146 RID: 12614
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialBuff_Public_get_DecorationBase_0;

		// Token: 0x04003147 RID: 12615
		private static readonly IntPtr NativeMethodInfoPtr_get_DecorationSettingType_Public_get_DecorationType_0;

		// Token: 0x04003148 RID: 12616
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictDecorationId_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x02000AB6 RID: 2742
		public enum DecorationType
		{
			// Token: 0x0400843D RID: 33853
			Outdoor,
			// Token: 0x0400843E RID: 33854
			Household,
			// Token: 0x0400843F RID: 33855
			FishingRod
		}
	}
}
