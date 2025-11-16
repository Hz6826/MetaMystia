using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x020002BD RID: 701
	public class CharacterSpriteSetCompact : ScriptableObject
	{
		// Token: 0x0600570A RID: 22282 RVA: 0x001C3B64 File Offset: 0x001C1D64
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSpriteSetCompact()
		{
			Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.CharacterUtility", "CharacterSpriteSetCompact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr);
			CharacterSpriteSetCompact.NativeFieldInfoPtr_mainSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "mainSprite");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_doNotUseEyeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "doNotUseEyeSprite");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_eyeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "eyeSprite");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_hasPrebakedShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "hasPrebakedShadow");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_animSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "animSpeedMultiplier");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_moveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "moveSpeedMultiplier");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_extraYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "extraYOffset");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_isHina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "isHina");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_rotatePerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "rotatePerTime");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_doNotHaveStepVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "doNotHaveStepVFX");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_daySceneInteractableHighlightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "daySceneInteractableHighlightOffset");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_daySceneInteractableColliderAdditiveRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "daySceneInteractableColliderAdditiveRadius");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_removableTrims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "removableTrims");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_trimSpritesDisplayFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "trimSpritesDisplayFront");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_trimSpritesDisplayBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "trimSpritesDisplayBack");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_trimFrontSpriteFrameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "trimFrontSpriteFrameSpeed");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_trimBackSpriteFrameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "trimBackSpriteFrameSpeed");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_spriteOffsetInNoteBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "spriteOffsetInNoteBook");
			CharacterSpriteSetCompact.NativeFieldInfoPtr_spriteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "spriteType");
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_MainSprite_Public_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681014);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_EyeSprite_Public_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681015);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_HairSprite_Public_Virtual_New_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681016);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_BackSprite_Public_Virtual_New_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681017);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_SpriteType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681018);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_HasPrebakedShadow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681019);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_AnimationSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681020);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681021);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_ExtraYOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681022);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_IsHina_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681023);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_RotatePerTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681024);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_DoNotHaveStepVFX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681025);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_DoNotUseEyeSprite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681026);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_RemovableTrims_Public_get_Il2CppReferenceArray_1_RemovableTrimProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681027);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimSpritesDisplayFront_Public_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681028);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimSpriteDisplayFrontInCard_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681029);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimSpritesDisplayBack_Public_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681030);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimSpriteDisplayBackInCard_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681031);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimFrontSpriteFrameSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681032);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimBackSpriteFrameSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681033);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_ShouldDisplayFront_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681034);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_ShouldDisplayBack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681035);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_DaySceneInteractableHighlightOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681036);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_DaySceneInteractableColliderAdditiveRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681037);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_get_SpriteOffsetInNoteBook_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681038);
			CharacterSpriteSetCompact.NativeMethodInfoPtr_Initialize_Public_Void_Il2CppReferenceArray_1_Sprite_Boolean_Il2CppReferenceArray_1_Sprite_Boolean_Single_Single_Boolean_Single_Boolean_Single_Il2CppReferenceArray_1_RemovableTrimProperty_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681039);
			CharacterSpriteSetCompact.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, 100681040);
		}

		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x0600570B RID: 22283 RVA: 0x001C3F2C File Offset: 0x001C212C
		public unsafe Il2CppReferenceArray<Sprite> MainSprite
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_MainSprite_Public_get_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600570C RID: 22284 RVA: 0x001C3F6C File Offset: 0x001C216C
		public unsafe Il2CppReferenceArray<Sprite> EyeSprite
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_EyeSprite_Public_get_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600570D RID: 22285 RVA: 0x001C3FAC File Offset: 0x001C21AC
		public unsafe virtual Il2CppReferenceArray<Sprite> HairSprite
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterSpriteSetCompact.NativeMethodInfoPtr_get_HairSprite_Public_Virtual_New_get_Il2CppReferenceArray_1_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001DEA RID: 7658
		// (get) Token: 0x0600570E RID: 22286 RVA: 0x001C3FF8 File Offset: 0x001C21F8
		public unsafe virtual Il2CppReferenceArray<Sprite> BackSprite
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterSpriteSetCompact.NativeMethodInfoPtr_get_BackSprite_Public_Virtual_New_get_Il2CppReferenceArray_1_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001DEB RID: 7659
		// (get) Token: 0x0600570F RID: 22287 RVA: 0x001C4044 File Offset: 0x001C2244
		public unsafe CharacterSpriteSetCompact.Type SpriteType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_SpriteType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DEC RID: 7660
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x001C4080 File Offset: 0x001C2280
		public unsafe bool HasPrebakedShadow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_HasPrebakedShadow_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DED RID: 7661
		// (get) Token: 0x06005711 RID: 22289 RVA: 0x001C40BC File Offset: 0x001C22BC
		public unsafe float AnimationSpeedMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_AnimationSpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DEE RID: 7662
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x001C40F8 File Offset: 0x001C22F8
		public unsafe float MoveSpeedMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x06005713 RID: 22291 RVA: 0x001C4134 File Offset: 0x001C2334
		public unsafe float ExtraYOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_ExtraYOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06005714 RID: 22292 RVA: 0x001C4170 File Offset: 0x001C2370
		public unsafe bool IsHina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_IsHina_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06005715 RID: 22293 RVA: 0x001C41AC File Offset: 0x001C23AC
		public unsafe float RotatePerTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_RotatePerTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x001C41E8 File Offset: 0x001C23E8
		public unsafe bool DoNotHaveStepVFX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_DoNotHaveStepVFX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06005717 RID: 22295 RVA: 0x001C4224 File Offset: 0x001C2424
		public unsafe bool DoNotUseEyeSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_DoNotUseEyeSprite_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06005718 RID: 22296 RVA: 0x001C4260 File Offset: 0x001C2460
		public unsafe Il2CppReferenceArray<CharacterSpriteSetCompact.RemovableTrimProperty> RemovableTrims
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_RemovableTrims_Public_get_Il2CppReferenceArray_1_RemovableTrimProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterSpriteSetCompact.RemovableTrimProperty>>(intPtr3) : null;
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06005719 RID: 22297 RVA: 0x001C42A0 File Offset: 0x001C24A0
		public unsafe Il2CppReferenceArray<Sprite> TrimSpritesDisplayFront
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimSpritesDisplayFront_Public_get_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x0600571A RID: 22298 RVA: 0x001C42E0 File Offset: 0x001C24E0
		public unsafe Sprite TrimSpriteDisplayFrontInCard
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 216032, RefRangeEnd = 216039, XrefRangeStart = 216032, XrefRangeEnd = 216032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimSpriteDisplayFrontInCard_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x0600571B RID: 22299 RVA: 0x001C4320 File Offset: 0x001C2520
		public unsafe Il2CppReferenceArray<Sprite> TrimSpritesDisplayBack
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimSpritesDisplayBack_Public_get_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x0600571C RID: 22300 RVA: 0x001C4360 File Offset: 0x001C2560
		public unsafe Sprite TrimSpriteDisplayBackInCard
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 216039, RefRangeEnd = 216046, XrefRangeStart = 216039, XrefRangeEnd = 216039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimSpriteDisplayBackInCard_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x0600571D RID: 22301 RVA: 0x001C43A0 File Offset: 0x001C25A0
		public unsafe float TrimFrontSpriteFrameSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimFrontSpriteFrameSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x0600571E RID: 22302 RVA: 0x001C43DC File Offset: 0x001C25DC
		public unsafe float TrimBackSpriteFrameSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_TrimBackSpriteFrameSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x0600571F RID: 22303 RVA: 0x001C4418 File Offset: 0x001C2618
		public unsafe bool ShouldDisplayFront
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 216046, RefRangeEnd = 216048, XrefRangeStart = 216046, XrefRangeEnd = 216046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_ShouldDisplayFront_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06005720 RID: 22304 RVA: 0x001C4454 File Offset: 0x001C2654
		public unsafe bool ShouldDisplayBack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 216048, RefRangeEnd = 216050, XrefRangeStart = 216048, XrefRangeEnd = 216048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_ShouldDisplayBack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x06005721 RID: 22305 RVA: 0x001C4490 File Offset: 0x001C2690
		public unsafe Vector2 DaySceneInteractableHighlightOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_DaySceneInteractableHighlightOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x06005722 RID: 22306 RVA: 0x001C44CC File Offset: 0x001C26CC
		public unsafe float DaySceneInteractableColliderAdditiveRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_DaySceneInteractableColliderAdditiveRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06005723 RID: 22307 RVA: 0x001C4508 File Offset: 0x001C2708
		public unsafe Vector2 SpriteOffsetInNoteBook
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_get_SpriteOffsetInNoteBook_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x001C4544 File Offset: 0x001C2744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216050, XrefRangeEnd = 216057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Il2CppReferenceArray<Sprite> mainSprite, bool doNotUseEyeSprite, Il2CppReferenceArray<Sprite> eyeSprite, bool hasPrebakedShadow, float animSpeedMultiplier, float extraYOffset, bool isHina, float rotatePerTime, bool doNotHaveStepVFX, float moveSpeedMultiplier, Il2CppReferenceArray<CharacterSpriteSetCompact.RemovableTrimProperty> removableTrims, Il2CppReferenceArray<Sprite> trimSpritesDisplayFront, Il2CppReferenceArray<Sprite> trimSpritesDisplayBack, float trimFrontSpriteFrameSpeed, float trimBackSpriteFrameSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mainSprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotUseEyeSprite;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyeSprite);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasPrebakedShadow;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animSpeedMultiplier;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraYOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHina;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotatePerTime;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotHaveStepVFX;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeedMultiplier;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(removableTrims);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimSpritesDisplayFront);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimSpritesDisplayBack);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trimFrontSpriteFrameSpeed;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trimBackSpriteFrameSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr_Initialize_Public_Void_Il2CppReferenceArray_1_Sprite_Boolean_Il2CppReferenceArray_1_Sprite_Boolean_Single_Single_Boolean_Single_Boolean_Single_Il2CppReferenceArray_1_RemovableTrimProperty_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x001C4664 File Offset: 0x001C2864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216057, XrefRangeEnd = 216065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSpriteSetCompact() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x0002EDE3 File Offset: 0x0002CFE3
		public CharacterSpriteSetCompact(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06005727 RID: 22311 RVA: 0x001C46A0 File Offset: 0x001C28A0
		// (set) Token: 0x06005728 RID: 22312 RVA: 0x0002EDEC File Offset: 0x0002CFEC
		public unsafe Il2CppReferenceArray<Sprite> mainSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_mainSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_mainSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06005729 RID: 22313 RVA: 0x001C46D0 File Offset: 0x001C28D0
		// (set) Token: 0x0600572A RID: 22314 RVA: 0x0002EE0B File Offset: 0x0002D00B
		public unsafe bool doNotUseEyeSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_doNotUseEyeSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_doNotUseEyeSprite)) = value;
			}
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x0600572B RID: 22315 RVA: 0x001C46F8 File Offset: 0x001C28F8
		// (set) Token: 0x0600572C RID: 22316 RVA: 0x0002EE26 File Offset: 0x0002D026
		public unsafe Il2CppReferenceArray<Sprite> eyeSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_eyeSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_eyeSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x0600572D RID: 22317 RVA: 0x001C4728 File Offset: 0x001C2928
		// (set) Token: 0x0600572E RID: 22318 RVA: 0x0002EE45 File Offset: 0x0002D045
		public unsafe bool hasPrebakedShadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_hasPrebakedShadow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_hasPrebakedShadow)) = value;
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600572F RID: 22319 RVA: 0x001C4750 File Offset: 0x001C2950
		// (set) Token: 0x06005730 RID: 22320 RVA: 0x0002EE60 File Offset: 0x0002D060
		public unsafe float animSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_animSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_animSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x06005731 RID: 22321 RVA: 0x001C4778 File Offset: 0x001C2978
		// (set) Token: 0x06005732 RID: 22322 RVA: 0x0002EE7B File Offset: 0x0002D07B
		public unsafe float moveSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_moveSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_moveSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06005733 RID: 22323 RVA: 0x001C47A0 File Offset: 0x001C29A0
		// (set) Token: 0x06005734 RID: 22324 RVA: 0x0002EE96 File Offset: 0x0002D096
		public unsafe float extraYOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_extraYOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_extraYOffset)) = value;
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x001C47C8 File Offset: 0x001C29C8
		// (set) Token: 0x06005736 RID: 22326 RVA: 0x0002EEB1 File Offset: 0x0002D0B1
		public unsafe bool isHina
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_isHina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_isHina)) = value;
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06005737 RID: 22327 RVA: 0x001C47F0 File Offset: 0x001C29F0
		// (set) Token: 0x06005738 RID: 22328 RVA: 0x0002EECC File Offset: 0x0002D0CC
		public unsafe float rotatePerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_rotatePerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_rotatePerTime)) = value;
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06005739 RID: 22329 RVA: 0x001C4818 File Offset: 0x001C2A18
		// (set) Token: 0x0600573A RID: 22330 RVA: 0x0002EEE7 File Offset: 0x0002D0E7
		public unsafe bool doNotHaveStepVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_doNotHaveStepVFX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_doNotHaveStepVFX)) = value;
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x0600573B RID: 22331 RVA: 0x001C4840 File Offset: 0x001C2A40
		// (set) Token: 0x0600573C RID: 22332 RVA: 0x0002EF02 File Offset: 0x0002D102
		public unsafe Vector2 daySceneInteractableHighlightOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_daySceneInteractableHighlightOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_daySceneInteractableHighlightOffset)) = value;
			}
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x001C4868 File Offset: 0x001C2A68
		// (set) Token: 0x0600573E RID: 22334 RVA: 0x0002EF1D File Offset: 0x0002D11D
		public unsafe float daySceneInteractableColliderAdditiveRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_daySceneInteractableColliderAdditiveRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_daySceneInteractableColliderAdditiveRadius)) = value;
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x001C4890 File Offset: 0x001C2A90
		// (set) Token: 0x06005740 RID: 22336 RVA: 0x0002EF38 File Offset: 0x0002D138
		public unsafe Il2CppReferenceArray<CharacterSpriteSetCompact.RemovableTrimProperty> removableTrims
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_removableTrims);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterSpriteSetCompact.RemovableTrimProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_removableTrims), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x06005741 RID: 22337 RVA: 0x001C48C0 File Offset: 0x001C2AC0
		// (set) Token: 0x06005742 RID: 22338 RVA: 0x0002EF57 File Offset: 0x0002D157
		public unsafe Il2CppReferenceArray<Sprite> trimSpritesDisplayFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_trimSpritesDisplayFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_trimSpritesDisplayFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x06005743 RID: 22339 RVA: 0x001C48F0 File Offset: 0x001C2AF0
		// (set) Token: 0x06005744 RID: 22340 RVA: 0x0002EF76 File Offset: 0x0002D176
		public unsafe Il2CppReferenceArray<Sprite> trimSpritesDisplayBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_trimSpritesDisplayBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_trimSpritesDisplayBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x06005745 RID: 22341 RVA: 0x001C4920 File Offset: 0x001C2B20
		// (set) Token: 0x06005746 RID: 22342 RVA: 0x0002EF95 File Offset: 0x0002D195
		public unsafe float trimFrontSpriteFrameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_trimFrontSpriteFrameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_trimFrontSpriteFrameSpeed)) = value;
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x06005747 RID: 22343 RVA: 0x001C4948 File Offset: 0x001C2B48
		// (set) Token: 0x06005748 RID: 22344 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
		public unsafe float trimBackSpriteFrameSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_trimBackSpriteFrameSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_trimBackSpriteFrameSpeed)) = value;
			}
		}

		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x06005749 RID: 22345 RVA: 0x001C4970 File Offset: 0x001C2B70
		// (set) Token: 0x0600574A RID: 22346 RVA: 0x0002EFCB File Offset: 0x0002D1CB
		public unsafe Vector2 spriteOffsetInNoteBook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_spriteOffsetInNoteBook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_spriteOffsetInNoteBook)) = value;
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x0600574B RID: 22347 RVA: 0x001C4998 File Offset: 0x001C2B98
		// (set) Token: 0x0600574C RID: 22348 RVA: 0x0002EFE6 File Offset: 0x0002D1E6
		public unsafe CharacterSpriteSetCompact.Type spriteType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_spriteType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.NativeFieldInfoPtr_spriteType)) = value;
			}
		}

		// Token: 0x04003A44 RID: 14916
		private static readonly IntPtr NativeFieldInfoPtr_mainSprite;

		// Token: 0x04003A45 RID: 14917
		private static readonly IntPtr NativeFieldInfoPtr_doNotUseEyeSprite;

		// Token: 0x04003A46 RID: 14918
		private static readonly IntPtr NativeFieldInfoPtr_eyeSprite;

		// Token: 0x04003A47 RID: 14919
		private static readonly IntPtr NativeFieldInfoPtr_hasPrebakedShadow;

		// Token: 0x04003A48 RID: 14920
		private static readonly IntPtr NativeFieldInfoPtr_animSpeedMultiplier;

		// Token: 0x04003A49 RID: 14921
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeedMultiplier;

		// Token: 0x04003A4A RID: 14922
		private static readonly IntPtr NativeFieldInfoPtr_extraYOffset;

		// Token: 0x04003A4B RID: 14923
		private static readonly IntPtr NativeFieldInfoPtr_isHina;

		// Token: 0x04003A4C RID: 14924
		private static readonly IntPtr NativeFieldInfoPtr_rotatePerTime;

		// Token: 0x04003A4D RID: 14925
		private static readonly IntPtr NativeFieldInfoPtr_doNotHaveStepVFX;

		// Token: 0x04003A4E RID: 14926
		private static readonly IntPtr NativeFieldInfoPtr_daySceneInteractableHighlightOffset;

		// Token: 0x04003A4F RID: 14927
		private static readonly IntPtr NativeFieldInfoPtr_daySceneInteractableColliderAdditiveRadius;

		// Token: 0x04003A50 RID: 14928
		private static readonly IntPtr NativeFieldInfoPtr_removableTrims;

		// Token: 0x04003A51 RID: 14929
		private static readonly IntPtr NativeFieldInfoPtr_trimSpritesDisplayFront;

		// Token: 0x04003A52 RID: 14930
		private static readonly IntPtr NativeFieldInfoPtr_trimSpritesDisplayBack;

		// Token: 0x04003A53 RID: 14931
		private static readonly IntPtr NativeFieldInfoPtr_trimFrontSpriteFrameSpeed;

		// Token: 0x04003A54 RID: 14932
		private static readonly IntPtr NativeFieldInfoPtr_trimBackSpriteFrameSpeed;

		// Token: 0x04003A55 RID: 14933
		private static readonly IntPtr NativeFieldInfoPtr_spriteOffsetInNoteBook;

		// Token: 0x04003A56 RID: 14934
		private static readonly IntPtr NativeFieldInfoPtr_spriteType;

		// Token: 0x04003A57 RID: 14935
		private static readonly IntPtr NativeMethodInfoPtr_get_MainSprite_Public_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A58 RID: 14936
		private static readonly IntPtr NativeMethodInfoPtr_get_EyeSprite_Public_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A59 RID: 14937
		private static readonly IntPtr NativeMethodInfoPtr_get_HairSprite_Public_Virtual_New_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A5A RID: 14938
		private static readonly IntPtr NativeMethodInfoPtr_get_BackSprite_Public_Virtual_New_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A5B RID: 14939
		private static readonly IntPtr NativeMethodInfoPtr_get_SpriteType_Public_get_Type_0;

		// Token: 0x04003A5C RID: 14940
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPrebakedShadow_Public_get_Boolean_0;

		// Token: 0x04003A5D RID: 14941
		private static readonly IntPtr NativeMethodInfoPtr_get_AnimationSpeedMultiplier_Public_get_Single_0;

		// Token: 0x04003A5E RID: 14942
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0;

		// Token: 0x04003A5F RID: 14943
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraYOffset_Public_get_Single_0;

		// Token: 0x04003A60 RID: 14944
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHina_Public_get_Boolean_0;

		// Token: 0x04003A61 RID: 14945
		private static readonly IntPtr NativeMethodInfoPtr_get_RotatePerTime_Public_get_Single_0;

		// Token: 0x04003A62 RID: 14946
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotHaveStepVFX_Public_get_Boolean_0;

		// Token: 0x04003A63 RID: 14947
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotUseEyeSprite_Public_get_Boolean_0;

		// Token: 0x04003A64 RID: 14948
		private static readonly IntPtr NativeMethodInfoPtr_get_RemovableTrims_Public_get_Il2CppReferenceArray_1_RemovableTrimProperty_0;

		// Token: 0x04003A65 RID: 14949
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimSpritesDisplayFront_Public_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A66 RID: 14950
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimSpriteDisplayFrontInCard_Public_get_Sprite_0;

		// Token: 0x04003A67 RID: 14951
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimSpritesDisplayBack_Public_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A68 RID: 14952
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimSpriteDisplayBackInCard_Public_get_Sprite_0;

		// Token: 0x04003A69 RID: 14953
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimFrontSpriteFrameSpeed_Public_get_Single_0;

		// Token: 0x04003A6A RID: 14954
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimBackSpriteFrameSpeed_Public_get_Single_0;

		// Token: 0x04003A6B RID: 14955
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldDisplayFront_Public_get_Boolean_0;

		// Token: 0x04003A6C RID: 14956
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldDisplayBack_Public_get_Boolean_0;

		// Token: 0x04003A6D RID: 14957
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneInteractableHighlightOffset_Public_get_Vector2_0;

		// Token: 0x04003A6E RID: 14958
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneInteractableColliderAdditiveRadius_Public_get_Single_0;

		// Token: 0x04003A6F RID: 14959
		private static readonly IntPtr NativeMethodInfoPtr_get_SpriteOffsetInNoteBook_Public_get_Vector2_0;

		// Token: 0x04003A70 RID: 14960
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Il2CppReferenceArray_1_Sprite_Boolean_Il2CppReferenceArray_1_Sprite_Boolean_Single_Single_Boolean_Single_Boolean_Single_Il2CppReferenceArray_1_RemovableTrimProperty_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Single_Single_0;

		// Token: 0x04003A71 RID: 14961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C83 RID: 3203
		public enum Type
		{
			// Token: 0x040092F7 RID: 37623
			Compact,
			// Token: 0x040092F8 RID: 37624
			Full
		}

		// Token: 0x02000C84 RID: 3204
		[Serializable]
		public sealed class RemovableTrimProperty : ValueType
		{
			// Token: 0x0600E619 RID: 58905 RVA: 0x003739F0 File Offset: 0x00371BF0
			// Note: this type is marked as 'beforefieldinit'.
			static RemovableTrimProperty()
			{
				Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterSpriteSetCompact>.NativeClassPtr, "RemovableTrimProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr);
				CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_removableTrimLayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr, "removableTrimLayerIndex");
				CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_removableTrimCompact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr, "removableTrimCompact");
				CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_canNotBeRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr, "canNotBeRemoved");
				CharacterSpriteSetCompact.RemovableTrimProperty.NativeMethodInfoPtr_get_RemovableTrimLayerIndex_Public_get_TrimPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr, 100681041);
				CharacterSpriteSetCompact.RemovableTrimProperty.NativeMethodInfoPtr_get_RemovableTrimCompact_Public_get_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr, 100681042);
				CharacterSpriteSetCompact.RemovableTrimProperty.NativeMethodInfoPtr_get_CanBeRemoved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr, 100681043);
			}

			// Token: 0x17004A9C RID: 19100
			// (get) Token: 0x0600E61A RID: 58906 RVA: 0x00373A94 File Offset: 0x00371C94
			public unsafe CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition RemovableTrimLayerIndex
			{
				[CallerCount(140)]
				[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.RemovableTrimProperty.NativeMethodInfoPtr_get_RemovableTrimLayerIndex_Public_get_TrimPosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17004A9D RID: 19101
			// (get) Token: 0x0600E61B RID: 58907 RVA: 0x00373AD8 File Offset: 0x00371CD8
			public unsafe CharacterSpriteSetCompact RemovableTrimCompact
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.RemovableTrimProperty.NativeMethodInfoPtr_get_RemovableTrimCompact_Public_get_CharacterSpriteSetCompact_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
				}
			}

			// Token: 0x17004A9E RID: 19102
			// (get) Token: 0x0600E61C RID: 58908 RVA: 0x00373B1C File Offset: 0x00371D1C
			public unsafe bool CanBeRemoved
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 20796, RefRangeEnd = 20797, XrefRangeStart = 20796, XrefRangeEnd = 20797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetCompact.RemovableTrimProperty.NativeMethodInfoPtr_get_CanBeRemoved_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E61D RID: 58909 RVA: 0x0007ADA6 File Offset: 0x00078FA6
			public RemovableTrimProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E61E RID: 58910 RVA: 0x0007ADAF File Offset: 0x00078FAF
			public RemovableTrimProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSpriteSetCompact.RemovableTrimProperty>.NativeClassPtr))
			{
			}

			// Token: 0x17004A99 RID: 19097
			// (get) Token: 0x0600E61F RID: 58911 RVA: 0x00373B60 File Offset: 0x00371D60
			// (set) Token: 0x0600E620 RID: 58912 RVA: 0x0007ADC1 File Offset: 0x00078FC1
			public unsafe CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition removableTrimLayerIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_removableTrimLayerIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_removableTrimLayerIndex)) = value;
				}
			}

			// Token: 0x17004A9A RID: 19098
			// (get) Token: 0x0600E621 RID: 58913 RVA: 0x00373B88 File Offset: 0x00371D88
			// (set) Token: 0x0600E622 RID: 58914 RVA: 0x0007ADDC File Offset: 0x00078FDC
			public unsafe CharacterSpriteSetCompact removableTrimCompact
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_removableTrimCompact);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_removableTrimCompact), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A9B RID: 19099
			// (get) Token: 0x0600E623 RID: 58915 RVA: 0x00373BB8 File Offset: 0x00371DB8
			// (set) Token: 0x0600E624 RID: 58916 RVA: 0x0007ADFB File Offset: 0x00078FFB
			public unsafe bool canNotBeRemoved
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_canNotBeRemoved);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetCompact.RemovableTrimProperty.NativeFieldInfoPtr_canNotBeRemoved)) = value;
				}
			}

			// Token: 0x040092F9 RID: 37625
			private static readonly IntPtr NativeFieldInfoPtr_removableTrimLayerIndex;

			// Token: 0x040092FA RID: 37626
			private static readonly IntPtr NativeFieldInfoPtr_removableTrimCompact;

			// Token: 0x040092FB RID: 37627
			private static readonly IntPtr NativeFieldInfoPtr_canNotBeRemoved;

			// Token: 0x040092FC RID: 37628
			private static readonly IntPtr NativeMethodInfoPtr_get_RemovableTrimLayerIndex_Public_get_TrimPosition_0;

			// Token: 0x040092FD RID: 37629
			private static readonly IntPtr NativeMethodInfoPtr_get_RemovableTrimCompact_Public_get_CharacterSpriteSetCompact_0;

			// Token: 0x040092FE RID: 37630
			private static readonly IntPtr NativeMethodInfoPtr_get_CanBeRemoved_Public_get_Boolean_0;

			// Token: 0x0200105B RID: 4187
			public enum TrimPosition
			{
				// Token: 0x0400B4DD RID: 46301
				BehindBack,
				// Token: 0x0400B4DE RID: 46302
				BehindBackAndFrontWing,
				// Token: 0x0400B4DF RID: 46303
				OnFace,
				// Token: 0x0400B4E0 RID: 46304
				Front
			}
		}
	}
}
