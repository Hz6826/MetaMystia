using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Common.DialogUtility
{
	// Token: 0x02000345 RID: 837
	[Serializable]
	public sealed class DialogMeta : ValueType
	{
		// Token: 0x06006378 RID: 25464 RVA: 0x001EB080 File Offset: 0x001E9280
		// Note: this type is marked as 'beforefieldinit'.
		static DialogMeta()
		{
			Il2CppClassPointerStore<DialogMeta>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility", "DialogMeta");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr);
			DialogMeta.NativeFieldInfoPtr_dialogId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "dialogId");
			DialogMeta.NativeFieldInfoPtr_dialogAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "dialogAction");
			DialogMeta.NativeFieldInfoPtr_speakerIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "speakerIdentity");
			DialogMeta.NativeFieldInfoPtr_speakerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "speakerPosition");
			DialogMeta.NativeFieldInfoPtr_isSpeakInForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "isSpeakInForeground");
			DialogMeta.NativeFieldInfoPtr_isDark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "isDark");
			DialogMeta.NativeFieldInfoPtr_useNameInText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "useNameInText");
			DialogMeta.NativeFieldInfoPtr_useOverrideSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "useOverrideSprite");
			DialogMeta.NativeFieldInfoPtr_m_OverrideSpriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, "m_OverrideSpriteAsset");
			DialogMeta.NativeMethodInfoPtr_get_OverrideSpriteValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, 100684221);
			DialogMeta.NativeMethodInfoPtr_LoadOverrideSprite_Public_UniTask_1_IAssetHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr, 100684222);
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x06006379 RID: 25465 RVA: 0x001EB18C File Offset: 0x001E938C
		public unsafe bool OverrideSpriteValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257122, XrefRangeEnd = 257123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogMeta.NativeMethodInfoPtr_get_OverrideSpriteValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600637A RID: 25466 RVA: 0x001EB1D0 File Offset: 0x001E93D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257134, RefRangeEnd = 257135, XrefRangeStart = 257123, XrefRangeEnd = 257134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask<IAssetHandle<Sprite>> LoadOverrideSprite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DialogMeta.NativeMethodInfoPtr_LoadOverrideSprite_Public_UniTask_1_IAssetHandle_1_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandle<Sprite>>(pointer);
		}

		// Token: 0x0600637B RID: 25467 RVA: 0x00035BE3 File Offset: 0x00033DE3
		public DialogMeta(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x00035BEC File Offset: 0x00033DEC
		public DialogMeta() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogMeta>.NativeClassPtr))
		{
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x0600637D RID: 25469 RVA: 0x001EB20C File Offset: 0x001E940C
		// (set) Token: 0x0600637E RID: 25470 RVA: 0x00035BFE File Offset: 0x00033DFE
		public unsafe int dialogId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_dialogId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_dialogId)) = value;
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x0600637F RID: 25471 RVA: 0x001EB234 File Offset: 0x001E9434
		// (set) Token: 0x06006380 RID: 25472 RVA: 0x00035C19 File Offset: 0x00033E19
		public unsafe Il2CppReferenceArray<DialogAction> dialogAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_dialogAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_dialogAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x06006381 RID: 25473 RVA: 0x001EB264 File Offset: 0x001E9464
		// (set) Token: 0x06006382 RID: 25474 RVA: 0x00035C38 File Offset: 0x00033E38
		public unsafe SpeakerIdentity speakerIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_speakerIdentity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_speakerIdentity)) = value;
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x06006383 RID: 25475 RVA: 0x001EB28C File Offset: 0x001E948C
		// (set) Token: 0x06006384 RID: 25476 RVA: 0x00035C53 File Offset: 0x00033E53
		public unsafe Position speakerPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_speakerPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_speakerPosition)) = value;
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x06006385 RID: 25477 RVA: 0x001EB2B4 File Offset: 0x001E94B4
		// (set) Token: 0x06006386 RID: 25478 RVA: 0x00035C6E File Offset: 0x00033E6E
		public unsafe bool isSpeakInForeground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_isSpeakInForeground);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_isSpeakInForeground)) = value;
			}
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x06006387 RID: 25479 RVA: 0x001EB2DC File Offset: 0x001E94DC
		// (set) Token: 0x06006388 RID: 25480 RVA: 0x00035C89 File Offset: 0x00033E89
		public unsafe bool isDark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_isDark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_isDark)) = value;
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x06006389 RID: 25481 RVA: 0x001EB304 File Offset: 0x001E9504
		// (set) Token: 0x0600638A RID: 25482 RVA: 0x00035CA4 File Offset: 0x00033EA4
		public unsafe bool useNameInText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_useNameInText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_useNameInText)) = value;
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x001EB32C File Offset: 0x001E952C
		// (set) Token: 0x0600638C RID: 25484 RVA: 0x00035CBF File Offset: 0x00033EBF
		public unsafe bool useOverrideSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_useOverrideSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_useOverrideSprite)) = value;
			}
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x0600638D RID: 25485 RVA: 0x001EB354 File Offset: 0x001E9554
		// (set) Token: 0x0600638E RID: 25486 RVA: 0x00035CDA File Offset: 0x00033EDA
		public unsafe AssetReferenceSprite m_OverrideSpriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_m_OverrideSpriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReferenceSprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogMeta.NativeFieldInfoPtr_m_OverrideSpriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004205 RID: 16901
		private static readonly IntPtr NativeFieldInfoPtr_dialogId;

		// Token: 0x04004206 RID: 16902
		private static readonly IntPtr NativeFieldInfoPtr_dialogAction;

		// Token: 0x04004207 RID: 16903
		private static readonly IntPtr NativeFieldInfoPtr_speakerIdentity;

		// Token: 0x04004208 RID: 16904
		private static readonly IntPtr NativeFieldInfoPtr_speakerPosition;

		// Token: 0x04004209 RID: 16905
		private static readonly IntPtr NativeFieldInfoPtr_isSpeakInForeground;

		// Token: 0x0400420A RID: 16906
		private static readonly IntPtr NativeFieldInfoPtr_isDark;

		// Token: 0x0400420B RID: 16907
		private static readonly IntPtr NativeFieldInfoPtr_useNameInText;

		// Token: 0x0400420C RID: 16908
		private static readonly IntPtr NativeFieldInfoPtr_useOverrideSprite;

		// Token: 0x0400420D RID: 16909
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideSpriteAsset;

		// Token: 0x0400420E RID: 16910
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideSpriteValid_Public_get_Boolean_0;

		// Token: 0x0400420F RID: 16911
		private static readonly IntPtr NativeMethodInfoPtr_LoadOverrideSprite_Public_UniTask_1_IAssetHandle_1_Sprite_0;
	}
}
