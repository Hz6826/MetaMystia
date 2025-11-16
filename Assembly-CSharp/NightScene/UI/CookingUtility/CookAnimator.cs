using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x020001D3 RID: 467
	public class CookAnimator : MonoBehaviour
	{
		// Token: 0x06003A87 RID: 14983 RVA: 0x00166174 File Offset: 0x00164374
		// Note: this type is marked as 'beforefieldinit'.
		static CookAnimator()
		{
			Il2CppClassPointerStore<CookAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.CookingUtility", "CookAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr);
			CookAnimator.NativeFieldInfoPtr_m_CookerSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_CookerSpriteRenderer");
			CookAnimator.NativeFieldInfoPtr_m_CookerLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_CookerLight");
			CookAnimator.NativeFieldInfoPtr_m_Cooking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_Cooking");
			CookAnimator.NativeFieldInfoPtr_m_CookingPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_CookingPhase");
			CookAnimator.NativeFieldInfoPtr_m_CurrentAnimatedTileFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_CurrentAnimatedTileFrameIndex");
			CookAnimator.NativeFieldInfoPtr_m_Idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_Idle");
			CookAnimator.NativeFieldInfoPtr_m_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_Initialized");
			CookAnimator.NativeFieldInfoPtr_m_LightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_LightIntensity");
			CookAnimator.NativeFieldInfoPtr_m_Loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_Loaded");
			CookAnimator.NativeFieldInfoPtr_m_NextAnimatedTileUpdateDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, "m_NextAnimatedTileUpdateDelta");
			CookAnimator.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674196);
			CookAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674197);
			CookAnimator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674198);
			CookAnimator.NativeMethodInfoPtr_Initialize_Public_Void_Cooker_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674199);
			CookAnimator.NativeMethodInfoPtr_SetAnimator_Public_Void_AnimatedTile_AnimatedTile_AnimatedTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674200);
			CookAnimator.NativeMethodInfoPtr_HideCookerPermanent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674201);
			CookAnimator.NativeMethodInfoPtr_RecoverCookerPermanent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674202);
			CookAnimator.NativeMethodInfoPtr_SetState_Public_Void_CookPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674203);
			CookAnimator.NativeMethodInfoPtr_UpdateLights_Private_Void_CookPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674204);
			CookAnimator.NativeMethodInfoPtr_UpdateSprites_Private_Void_CookPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674205);
			CookAnimator.NativeMethodInfoPtr_UpdateAnimatedTile_Private_Void_AnimatedTile_byref_Single_byref_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674206);
			CookAnimator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674207);
			CookAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr, 100674208);
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x00166370 File Offset: 0x00164570
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 133237, RefRangeEnd = 133241, XrefRangeStart = 133221, XrefRangeEnd = 133237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A89 RID: 14985 RVA: 0x001663A4 File Offset: 0x001645A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133241, XrefRangeEnd = 133245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x001663D8 File Offset: 0x001645D8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x0016640C File Offset: 0x0016460C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133252, RefRangeEnd = 133254, XrefRangeStart = 133245, XrefRangeEnd = 133252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cooker cookerInfo, Vector3 cookerWorldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookerInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookerWorldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_Initialize_Public_Void_Cooker_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x0016645C File Offset: 0x0016465C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133257, RefRangeEnd = 133258, XrefRangeStart = 133254, XrefRangeEnd = 133257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimator(AnimatedTile idle, AnimatedTile loaded, AnimatedTile cooking)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(idle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loaded);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cooking);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_SetAnimator_Public_Void_AnimatedTile_AnimatedTile_AnimatedTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x001664C4 File Offset: 0x001646C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 133261, RefRangeEnd = 133266, XrefRangeStart = 133258, XrefRangeEnd = 133261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideCookerPermanent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_HideCookerPermanent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x001664F8 File Offset: 0x001646F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133266, XrefRangeEnd = 133269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecoverCookerPermanent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_RecoverCookerPermanent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x0016652C File Offset: 0x0016472C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 133270, RefRangeEnd = 133282, XrefRangeStart = 133269, XrefRangeEnd = 133270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(CookController.CookPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_SetState_Public_Void_CookPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x0016656C File Offset: 0x0016476C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133316, RefRangeEnd = 133317, XrefRangeStart = 133282, XrefRangeEnd = 133316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLights(CookController.CookPhase currentPhase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentPhase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_UpdateLights_Private_Void_CookPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x001665AC File Offset: 0x001647AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133317, XrefRangeEnd = 133320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSprites(CookController.CookPhase currentPhase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentPhase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_UpdateSprites_Private_Void_CookPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x001665EC File Offset: 0x001647EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133336, RefRangeEnd = 133338, XrefRangeStart = 133320, XrefRangeEnd = 133336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnimatedTile(AnimatedTile tile, ref float nextUpdate, ref Nullable<int> nextIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nextUpdate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(nextIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr_UpdateAnimatedTile_Private_Void_AnimatedTile_byref_Single_byref_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00166650 File Offset: 0x00164850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133338, XrefRangeEnd = 133343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookAnimator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x0016668C File Offset: 0x0016488C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x00020C8E File Offset: 0x0001EE8E
		public CookAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06003A96 RID: 14998 RVA: 0x001666C8 File Offset: 0x001648C8
		// (set) Token: 0x06003A97 RID: 14999 RVA: 0x00020C97 File Offset: 0x0001EE97
		public unsafe SpriteRenderer m_CookerSpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_CookerSpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_CookerSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x001666F8 File Offset: 0x001648F8
		// (set) Token: 0x06003A99 RID: 15001 RVA: 0x00020CB6 File Offset: 0x0001EEB6
		public unsafe List<SpriteRenderer> m_CookerLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_CookerLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_CookerLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x06003A9A RID: 15002 RVA: 0x00166728 File Offset: 0x00164928
		// (set) Token: 0x06003A9B RID: 15003 RVA: 0x00020CD5 File Offset: 0x0001EED5
		public unsafe AnimatedTile m_Cooking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_Cooking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_Cooking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x06003A9C RID: 15004 RVA: 0x00166758 File Offset: 0x00164958
		// (set) Token: 0x06003A9D RID: 15005 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		public unsafe CookController.CookPhase m_CookingPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_CookingPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_CookingPhase)) = value;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x06003A9E RID: 15006 RVA: 0x00166780 File Offset: 0x00164980
		// (set) Token: 0x06003A9F RID: 15007 RVA: 0x00020D0F File Offset: 0x0001EF0F
		public Nullable<int> m_CurrentAnimatedTileFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_CurrentAnimatedTileFrameIndex);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_CurrentAnimatedTileFrameIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06003AA0 RID: 15008 RVA: 0x001667B0 File Offset: 0x001649B0
		// (set) Token: 0x06003AA1 RID: 15009 RVA: 0x00020D3D File Offset: 0x0001EF3D
		public unsafe AnimatedTile m_Idle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_Idle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_Idle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x001667E0 File Offset: 0x001649E0
		// (set) Token: 0x06003AA3 RID: 15011 RVA: 0x00020D5C File Offset: 0x0001EF5C
		public unsafe bool m_Initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_Initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_Initialized)) = value;
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06003AA4 RID: 15012 RVA: 0x00166808 File Offset: 0x00164A08
		// (set) Token: 0x06003AA5 RID: 15013 RVA: 0x00020D77 File Offset: 0x0001EF77
		public unsafe float m_LightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_LightIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_LightIntensity)) = value;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06003AA6 RID: 15014 RVA: 0x00166830 File Offset: 0x00164A30
		// (set) Token: 0x06003AA7 RID: 15015 RVA: 0x00020D92 File Offset: 0x0001EF92
		public unsafe AnimatedTile m_Loaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_Loaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_Loaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06003AA8 RID: 15016 RVA: 0x00166860 File Offset: 0x00164A60
		// (set) Token: 0x06003AA9 RID: 15017 RVA: 0x00020DB1 File Offset: 0x0001EFB1
		public unsafe float m_NextAnimatedTileUpdateDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_NextAnimatedTileUpdateDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookAnimator.NativeFieldInfoPtr_m_NextAnimatedTileUpdateDelta)) = value;
			}
		}

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerSpriteRenderer;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerLight;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeFieldInfoPtr_m_Cooking;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeFieldInfoPtr_m_CookingPhase;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentAnimatedTileFrameIndex;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeFieldInfoPtr_m_Idle;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeFieldInfoPtr_m_Initialized;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeFieldInfoPtr_m_LightIntensity;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeFieldInfoPtr_m_Loaded;

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeFieldInfoPtr_m_NextAnimatedTileUpdateDelta;

		// Token: 0x04002764 RID: 10084
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04002765 RID: 10085
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002766 RID: 10086
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002767 RID: 10087
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cooker_Vector3_0;

		// Token: 0x04002768 RID: 10088
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimator_Public_Void_AnimatedTile_AnimatedTile_AnimatedTile_0;

		// Token: 0x04002769 RID: 10089
		private static readonly IntPtr NativeMethodInfoPtr_HideCookerPermanent_Public_Void_0;

		// Token: 0x0400276A RID: 10090
		private static readonly IntPtr NativeMethodInfoPtr_RecoverCookerPermanent_Public_Void_0;

		// Token: 0x0400276B RID: 10091
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_CookPhase_0;

		// Token: 0x0400276C RID: 10092
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLights_Private_Void_CookPhase_0;

		// Token: 0x0400276D RID: 10093
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSprites_Private_Void_CookPhase_0;

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimatedTile_Private_Void_AnimatedTile_byref_Single_byref_Nullable_1_Int32_0;

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
