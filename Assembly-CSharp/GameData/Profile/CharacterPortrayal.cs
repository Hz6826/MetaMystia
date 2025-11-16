using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x020002C6 RID: 710
	public class CharacterPortrayal : ScriptableObject
	{
		// Token: 0x06005847 RID: 22599 RVA: 0x001C8118 File Offset: 0x001C6318
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterPortrayal()
		{
			Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CharacterPortrayal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr);
			CharacterPortrayal.NativeFieldInfoPtr_positiveSpellCardFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, "positiveSpellCardFace");
			CharacterPortrayal.NativeFieldInfoPtr_negativeSpellCardFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, "negativeSpellCardFace");
			CharacterPortrayal.NativeFieldInfoPtr_faceInNoteBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, "faceInNoteBook");
			CharacterPortrayal.NativeFieldInfoPtr_m_VisualAssetAtlasReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, "m_VisualAssetAtlasReference");
			CharacterPortrayal.NativeMethodInfoPtr_LoadVisualHandle_Private_UniTask_1_IAssetHandle_1_Sprite_Int32_AssetLifetime_Nullable_1_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, 100681245);
			CharacterPortrayal.NativeMethodInfoPtr_LoadAllVisualHandles_Public_UniTask_1_IAssetHandleArray_1_Sprite_AssetLifetime_Nullable_1_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, 100681246);
			CharacterPortrayal.NativeMethodInfoPtr_LoadNotebookVisual_Public_UniTask_1_IAssetHandle_1_Sprite_AssetLifetime_Nullable_1_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, 100681247);
			CharacterPortrayal.NativeMethodInfoPtr_LoadSpellPortrayal_Public_ValueTuple_2_UniTask_1_IAssetHandle_1_Sprite_UniTask_1_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, 100681248);
			CharacterPortrayal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr, 100681249);
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x001C81FC File Offset: 0x001C63FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218619, XrefRangeEnd = 218626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<IAssetHandle<Sprite>> LoadVisualHandle(int index, AssetLifetime assetLifetime, Nullable<CancellationToken> cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assetLifetime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterPortrayal.NativeMethodInfoPtr_LoadVisualHandle_Private_UniTask_1_IAssetHandle_1_Sprite_Int32_AssetLifetime_Nullable_1_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandle<Sprite>>(pointer);
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x001C8268 File Offset: 0x001C6468
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 218633, RefRangeEnd = 218638, XrefRangeStart = 218626, XrefRangeEnd = 218633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<IAssetHandleArray<Sprite>> LoadAllVisualHandles(AssetLifetime assetLifetime, Nullable<CancellationToken> cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref assetLifetime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterPortrayal.NativeMethodInfoPtr_LoadAllVisualHandles_Public_UniTask_1_IAssetHandleArray_1_Sprite_AssetLifetime_Nullable_1_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandleArray<Sprite>>(pointer);
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x001C82C4 File Offset: 0x001C64C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 218666, RefRangeEnd = 218672, XrefRangeStart = 218638, XrefRangeEnd = 218666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<IAssetHandle<Sprite>> LoadNotebookVisual(AssetLifetime assetLifetime, Nullable<CancellationToken> cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref assetLifetime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterPortrayal.NativeMethodInfoPtr_LoadNotebookVisual_Public_UniTask_1_IAssetHandle_1_Sprite_AssetLifetime_Nullable_1_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandle<Sprite>>(pointer);
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x001C8320 File Offset: 0x001C6520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218696, RefRangeEnd = 218698, XrefRangeStart = 218672, XrefRangeEnd = 218696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<UniTask<IAssetHandle<Sprite>>, UniTask<IAssetHandle<Sprite>>> LoadSpellPortrayal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterPortrayal.NativeMethodInfoPtr_LoadSpellPortrayal_Public_ValueTuple_2_UniTask_1_IAssetHandle_1_Sprite_UniTask_1_IAssetHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<UniTask<IAssetHandle<Sprite>>, UniTask<IAssetHandle<Sprite>>>(pointer);
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x001C8358 File Offset: 0x001C6558
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterPortrayal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterPortrayal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterPortrayal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x0002F502 File Offset: 0x0002D702
		public CharacterPortrayal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x001C8394 File Offset: 0x001C6594
		// (set) Token: 0x0600584F RID: 22607 RVA: 0x0002F50B File Offset: 0x0002D70B
		public unsafe int positiveSpellCardFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPortrayal.NativeFieldInfoPtr_positiveSpellCardFace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPortrayal.NativeFieldInfoPtr_positiveSpellCardFace)) = value;
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06005850 RID: 22608 RVA: 0x001C83BC File Offset: 0x001C65BC
		// (set) Token: 0x06005851 RID: 22609 RVA: 0x0002F526 File Offset: 0x0002D726
		public unsafe int negativeSpellCardFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPortrayal.NativeFieldInfoPtr_negativeSpellCardFace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPortrayal.NativeFieldInfoPtr_negativeSpellCardFace)) = value;
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x06005852 RID: 22610 RVA: 0x001C83E4 File Offset: 0x001C65E4
		// (set) Token: 0x06005853 RID: 22611 RVA: 0x0002F541 File Offset: 0x0002D741
		public unsafe int faceInNoteBook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPortrayal.NativeFieldInfoPtr_faceInNoteBook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPortrayal.NativeFieldInfoPtr_faceInNoteBook)) = value;
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06005854 RID: 22612 RVA: 0x001C840C File Offset: 0x001C660C
		// (set) Token: 0x06005855 RID: 22613 RVA: 0x0002F55C File Offset: 0x0002D75C
		public unsafe Il2CppReferenceArray<AssetReferenceAtlasedSprite> m_VisualAssetAtlasReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPortrayal.NativeFieldInfoPtr_m_VisualAssetAtlasReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AssetReferenceAtlasedSprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPortrayal.NativeFieldInfoPtr_m_VisualAssetAtlasReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B24 RID: 15140
		private static readonly IntPtr NativeFieldInfoPtr_positiveSpellCardFace;

		// Token: 0x04003B25 RID: 15141
		private static readonly IntPtr NativeFieldInfoPtr_negativeSpellCardFace;

		// Token: 0x04003B26 RID: 15142
		private static readonly IntPtr NativeFieldInfoPtr_faceInNoteBook;

		// Token: 0x04003B27 RID: 15143
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualAssetAtlasReference;

		// Token: 0x04003B28 RID: 15144
		private static readonly IntPtr NativeMethodInfoPtr_LoadVisualHandle_Private_UniTask_1_IAssetHandle_1_Sprite_Int32_AssetLifetime_Nullable_1_CancellationToken_0;

		// Token: 0x04003B29 RID: 15145
		private static readonly IntPtr NativeMethodInfoPtr_LoadAllVisualHandles_Public_UniTask_1_IAssetHandleArray_1_Sprite_AssetLifetime_Nullable_1_CancellationToken_0;

		// Token: 0x04003B2A RID: 15146
		private static readonly IntPtr NativeMethodInfoPtr_LoadNotebookVisual_Public_UniTask_1_IAssetHandle_1_Sprite_AssetLifetime_Nullable_1_CancellationToken_0;

		// Token: 0x04003B2B RID: 15147
		private static readonly IntPtr NativeMethodInfoPtr_LoadSpellPortrayal_Public_ValueTuple_2_UniTask_1_IAssetHandle_1_Sprite_UniTask_1_IAssetHandle_1_Sprite_0;

		// Token: 0x04003B2C RID: 15148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
