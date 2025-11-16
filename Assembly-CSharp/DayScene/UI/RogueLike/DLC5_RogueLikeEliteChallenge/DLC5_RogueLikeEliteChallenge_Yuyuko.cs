using System;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge
{
	// Token: 0x0200013D RID: 317
	public class DLC5_RogueLikeEliteChallenge_Yuyuko : RogueLikeRunTimeData.EliteChallengeBase
	{
		// Token: 0x06002606 RID: 9734 RVA: 0x0011E13C File Offset: 0x0011C33C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteChallenge_Yuyuko()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge", "DLC5_RogueLikeEliteChallenge_Yuyuko");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr);
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_baseHealthValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "baseHealthValue");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_extraHPPerWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "extraHPPerWave");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_CHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "YUYUKO_CHALLENGE");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUUMA_CHALLENGE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "YUUMA_CHALLENGE_TITLE");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUUMA_CHALLENGE_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "YUUMA_CHALLENGE_END");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_CHALLENGE_DESCRIPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "YUYUKO_CHALLENGE_DESCRIPTION");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_ELITE_FINISH_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "YUYUKO_ELITE_FINISH_LABEL");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "YUYUKO_ID");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_MAX_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "YUYUKO_MAX_HP");
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, 100670130);
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, 100670131);
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, 100670132);
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, 100670133);
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, 100670134);
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, 100670135);
			DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_Method_Internal_Static_Int32_OrderBase_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, 100670136);
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x0011E2AC File Offset: 0x0011C4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89998, XrefRangeEnd = 90001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x0011E300 File Offset: 0x0011C500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90001, XrefRangeEnd = 90009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x0011E368 File Offset: 0x0011C568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90009, XrefRangeEnd = 90013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RogueLikeRunTimeData.EliteChallengeCache GenerateEliteChallengeCache(RogueLikeRunTimeData rogueLikeRunTimeData, string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.EliteChallengeCache>(intPtr3) : null;
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x0011E3D8 File Offset: 0x0011C5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90013, XrefRangeEnd = 90137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(statusDisplay);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roguelikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x0011E464 File Offset: 0x0011C664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90137, XrefRangeEnd = 90144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0011E4D4 File Offset: 0x0011C6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90144, XrefRangeEnd = 90145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteChallenge_Yuyuko() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x0011E510 File Offset: 0x0011C710
		[CallerCount(0)]
		public unsafe static int Method_Internal_Static_Int32_OrderBase_PDM_0(GuestsManager.OrderBase orderBase)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeMethodInfoPtr_Method_Internal_Static_Int32_OrderBase_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00016745 File Offset: 0x00014945
		public DLC5_RogueLikeEliteChallenge_Yuyuko(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x0011E554 File Offset: 0x0011C754
		// (set) Token: 0x06002610 RID: 9744 RVA: 0x0001674E File Offset: 0x0001494E
		public unsafe int baseHealthValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_baseHealthValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_baseHealthValue)) = value;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x0011E57C File Offset: 0x0011C77C
		// (set) Token: 0x06002612 RID: 9746 RVA: 0x00016769 File Offset: 0x00014969
		public unsafe int extraHPPerWave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_extraHPPerWave);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_extraHPPerWave)) = value;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x0011E5A4 File Offset: 0x0011C7A4
		// (set) Token: 0x06002614 RID: 9748 RVA: 0x00016784 File Offset: 0x00014984
		public unsafe static string YUYUKO_CHALLENGE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_CHALLENGE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_CHALLENGE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x0011E5C4 File Offset: 0x0011C7C4
		// (set) Token: 0x06002616 RID: 9750 RVA: 0x00016796 File Offset: 0x00014996
		public unsafe static string YUUMA_CHALLENGE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUUMA_CHALLENGE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUUMA_CHALLENGE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x0011E5E4 File Offset: 0x0011C7E4
		// (set) Token: 0x06002618 RID: 9752 RVA: 0x000167A8 File Offset: 0x000149A8
		public unsafe static string YUUMA_CHALLENGE_END
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUUMA_CHALLENGE_END, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUUMA_CHALLENGE_END, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x0011E604 File Offset: 0x0011C804
		// (set) Token: 0x0600261A RID: 9754 RVA: 0x000167BA File Offset: 0x000149BA
		public unsafe static string YUYUKO_CHALLENGE_DESCRIPTION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_CHALLENGE_DESCRIPTION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_CHALLENGE_DESCRIPTION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x0011E624 File Offset: 0x0011C824
		// (set) Token: 0x0600261C RID: 9756 RVA: 0x000167CC File Offset: 0x000149CC
		public unsafe static string YUYUKO_ELITE_FINISH_LABEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_ELITE_FINISH_LABEL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_ELITE_FINISH_LABEL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x0011E644 File Offset: 0x0011C844
		// (set) Token: 0x0600261E RID: 9758 RVA: 0x000167DE File Offset: 0x000149DE
		public unsafe static int YUYUKO_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_ID, (void*)(&value));
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x0600261F RID: 9759 RVA: 0x0011E660 File Offset: 0x0011C860
		// (set) Token: 0x06002620 RID: 9760 RVA: 0x000167EC File Offset: 0x000149EC
		public unsafe static int YUYUKO_MAX_HP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_MAX_HP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.NativeFieldInfoPtr_YUYUKO_MAX_HP, (void*)(&value));
			}
		}

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeFieldInfoPtr_baseHealthValue;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeFieldInfoPtr_extraHPPerWave;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeFieldInfoPtr_YUYUKO_CHALLENGE;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeFieldInfoPtr_YUUMA_CHALLENGE_TITLE;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeFieldInfoPtr_YUUMA_CHALLENGE_END;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeFieldInfoPtr_YUYUKO_CHALLENGE_DESCRIPTION;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeFieldInfoPtr_YUYUKO_ELITE_FINISH_LABEL;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeFieldInfoPtr_YUYUKO_ID;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeFieldInfoPtr_YUYUKO_MAX_HP;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteTitle_Public_Virtual_String_EliteChallengeCache_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteDescription_Public_Virtual_String_EliteChallengeCache_String_0;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeMethodInfoPtr_GenerateEliteChallengeCache_Public_Virtual_EliteChallengeCache_RogueLikeRunTimeData_String_0;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossChallenge_Public_Virtual_Void_RogueLikeRunTimeData_BossDataContext_IncomeControllerRogueLike_RogueLikeManager_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_EliteBossSpellCardDeclaration_Public_Virtual_IEnumerator_EventManager_RogueLikeRunTimeData_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_OrderBase_PDM_0;

		// Token: 0x0200077E RID: 1918
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yuyuko+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A282 RID: 41602 RVA: 0x002AAF04 File Offset: 0x002A9104
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_hpProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "hpProgress");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyuko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "yuyuko");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoHungryValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "yuyukoHungryValue");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoTotalLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "yuyukoTotalLife");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_mainLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "mainLoop");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "bossDataContext");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "canContinue");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "yuyukoLikedFoodTagUnfolded");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "yuyukoLikedBevTagUnfolded");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_uiElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "uiElement");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr___9__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "<>9__11");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670137);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670138);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670139);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670140);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__8_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670141);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__9_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670142);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670143);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670144);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__10_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670145);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__11_Internal_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670146);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__12_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670147);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670148);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__14_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, 100670149);
			}

			// Token: 0x0600A283 RID: 41603 RVA: 0x002AB110 File Offset: 0x002A9310
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A284 RID: 41604 RVA: 0x002AB14C File Offset: 0x002A934C
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A285 RID: 41605 RVA: 0x002AB190 File Offset: 0x002A9390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89894, XrefRangeEnd = 89899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult lastResult, GuestGroupController __, bool oldComboProtect, out string message, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref lastResult;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				message = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600A286 RID: 41606 RVA: 0x002AB224 File Offset: 0x002A9424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89899, XrefRangeEnd = 89907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__7(GuestGroupController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A287 RID: 41607 RVA: 0x002AB268 File Offset: 0x002A9468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89907, XrefRangeEnd = 89909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EliteBossChallenge_b__8(int _, string _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__8_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A288 RID: 41608 RVA: 0x002AB2C0 File Offset: 0x002A94C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _EliteBossChallenge_b__9(int _, string _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__9_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A289 RID: 41609 RVA: 0x002AB318 File Offset: 0x002A9518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89909, XrefRangeEnd = 89925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A28A RID: 41610 RVA: 0x002AB34C File Offset: 0x002A954C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89925, XrefRangeEnd = 89930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A28B RID: 41611 RVA: 0x002AB38C File Offset: 0x002A958C
			[CallerCount(0)]
			public unsafe bool _EliteBossChallenge_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__10_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A28C RID: 41612 RVA: 0x002AB3C8 File Offset: 0x002A95C8
			[CallerCount(0)]
			public unsafe void _EliteBossChallenge_b__11(GuestGroupController.EvaluationResult _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__11_Internal_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A28D RID: 41613 RVA: 0x002AB408 File Offset: 0x002A9608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89930, XrefRangeEnd = 89954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__12(GuestGroupController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__12_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A28E RID: 41614 RVA: 0x002AB44C File Offset: 0x002A964C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 89963, RefRangeEnd = 89964, XrefRangeStart = 89954, XrefRangeEnd = 89963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A28F RID: 41615 RVA: 0x002AB480 File Offset: 0x002A9680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89964, XrefRangeEnd = 89976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__14(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeMethodInfoPtr__EliteBossChallenge_b__14_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A290 RID: 41616 RVA: 0x00057CCE File Offset: 0x00055ECE
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035A3 RID: 13731
			// (get) Token: 0x0600A291 RID: 41617 RVA: 0x002AB4C4 File Offset: 0x002A96C4
			// (set) Token: 0x0600A292 RID: 41618 RVA: 0x00057CD7 File Offset: 0x00055ED7
			public unsafe Image hpProgress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_hpProgress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_hpProgress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035A4 RID: 13732
			// (get) Token: 0x0600A293 RID: 41619 RVA: 0x002AB4F4 File Offset: 0x002A96F4
			// (set) Token: 0x0600A294 RID: 41620 RVA: 0x00057CF6 File Offset: 0x00055EF6
			public unsafe SpecialGuestsController yuyuko
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyuko);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyuko), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035A5 RID: 13733
			// (get) Token: 0x0600A295 RID: 41621 RVA: 0x002AB524 File Offset: 0x002A9724
			// (set) Token: 0x0600A296 RID: 41622 RVA: 0x00057D15 File Offset: 0x00055F15
			public unsafe int yuyukoHungryValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoHungryValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoHungryValue)) = value;
				}
			}

			// Token: 0x170035A6 RID: 13734
			// (get) Token: 0x0600A297 RID: 41623 RVA: 0x002AB54C File Offset: 0x002A974C
			// (set) Token: 0x0600A298 RID: 41624 RVA: 0x00057D30 File Offset: 0x00055F30
			public unsafe int yuyukoTotalLife
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoTotalLife);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoTotalLife)) = value;
				}
			}

			// Token: 0x170035A7 RID: 13735
			// (get) Token: 0x0600A299 RID: 41625 RVA: 0x002AB574 File Offset: 0x002A9774
			// (set) Token: 0x0600A29A RID: 41626 RVA: 0x00057D4B File Offset: 0x00055F4B
			public unsafe Coroutine mainLoop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_mainLoop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_mainLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035A8 RID: 13736
			// (get) Token: 0x0600A29B RID: 41627 RVA: 0x002AB5A4 File Offset: 0x002A97A4
			// (set) Token: 0x0600A29C RID: 41628 RVA: 0x00057D6A File Offset: 0x00055F6A
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170035A9 RID: 13737
			// (get) Token: 0x0600A29D RID: 41629 RVA: 0x002AB5D4 File Offset: 0x002A97D4
			// (set) Token: 0x0600A29E RID: 41630 RVA: 0x00057D98 File Offset: 0x00055F98
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x170035AA RID: 13738
			// (get) Token: 0x0600A29F RID: 41631 RVA: 0x002AB5FC File Offset: 0x002A97FC
			// (set) Token: 0x0600A2A0 RID: 41632 RVA: 0x00057DB3 File Offset: 0x00055FB3
			public unsafe Il2CppStructArray<int> yuyukoLikedFoodTagUnfolded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035AB RID: 13739
			// (get) Token: 0x0600A2A1 RID: 41633 RVA: 0x002AB62C File Offset: 0x002A982C
			// (set) Token: 0x0600A2A2 RID: 41634 RVA: 0x00057DD2 File Offset: 0x00055FD2
			public unsafe Il2CppStructArray<int> yuyukoLikedBevTagUnfolded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035AC RID: 13740
			// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x002AB65C File Offset: 0x002A985C
			// (set) Token: 0x0600A2A4 RID: 41636 RVA: 0x00057DF1 File Offset: 0x00055FF1
			public unsafe UIElementCluster uiElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_uiElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr_uiElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035AD RID: 13741
			// (get) Token: 0x0600A2A5 RID: 41637 RVA: 0x002AB68C File Offset: 0x002A988C
			// (set) Token: 0x0600A2A6 RID: 41638 RVA: 0x00057E10 File Offset: 0x00056010
			public unsafe Action<GuestGroupController.EvaluationResult> __9__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr___9__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.NativeFieldInfoPtr___9__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400693C RID: 26940
			private static readonly IntPtr NativeFieldInfoPtr_hpProgress;

			// Token: 0x0400693D RID: 26941
			private static readonly IntPtr NativeFieldInfoPtr_yuyuko;

			// Token: 0x0400693E RID: 26942
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoHungryValue;

			// Token: 0x0400693F RID: 26943
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoTotalLife;

			// Token: 0x04006940 RID: 26944
			private static readonly IntPtr NativeFieldInfoPtr_mainLoop;

			// Token: 0x04006941 RID: 26945
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x04006942 RID: 26946
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04006943 RID: 26947
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded;

			// Token: 0x04006944 RID: 26948
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded;

			// Token: 0x04006945 RID: 26949
			private static readonly IntPtr NativeFieldInfoPtr_uiElement;

			// Token: 0x04006946 RID: 26950
			private static readonly IntPtr NativeFieldInfoPtr___9__11;

			// Token: 0x04006947 RID: 26951
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006948 RID: 26952
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__0_Internal_Void_Image_0;

			// Token: 0x04006949 RID: 26953
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;

			// Token: 0x0400694A RID: 26954
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__7_Internal_Void_GuestGroupController_0;

			// Token: 0x0400694B RID: 26955
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__8_Internal_String_Int32_String_0;

			// Token: 0x0400694C RID: 26956
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__9_Internal_String_Int32_String_0;

			// Token: 0x0400694D RID: 26957
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400694E RID: 26958
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400694F RID: 26959
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__10_Internal_Boolean_0;

			// Token: 0x04006950 RID: 26960
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__11_Internal_Void_EvaluationResult_0;

			// Token: 0x04006951 RID: 26961
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__12_Internal_Void_GuestGroupController_0;

			// Token: 0x04006952 RID: 26962
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04006953 RID: 26963
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__14_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x02000FDE RID: 4062
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yuyuko+<>c__DisplayClass12_0+<<EliteBossChallenge>g__Phase3OrderLoop|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011718 RID: 71448 RVA: 0x00401E48 File Offset: 0x00400048
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>.NativeClassPtr, "<<EliteBossChallenge>g__Phase3OrderLoop|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr);
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>1__state");
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>2__current");
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>4__this");
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__canContinueYieldInstruction_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<canContinueYieldInstruction>5__2");
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100670150);
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100670151);
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100670152);
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100670153);
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100670154);
					DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100670155);
				}

				// Token: 0x06011719 RID: 71449 RVA: 0x00401F3C File Offset: 0x0040013C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601171A RID: 71450 RVA: 0x00401F84 File Offset: 0x00400184
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601171B RID: 71451 RVA: 0x00401FB8 File Offset: 0x004001B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89841, XrefRangeEnd = 89888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005AAF RID: 23215
				// (get) Token: 0x0601171C RID: 71452 RVA: 0x00401FF4 File Offset: 0x004001F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601171D RID: 71453 RVA: 0x00402034 File Offset: 0x00400234
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89888, XrefRangeEnd = 89894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005AB0 RID: 23216
				// (get) Token: 0x0601171E RID: 71454 RVA: 0x00402068 File Offset: 0x00400268
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601171F RID: 71455 RVA: 0x00097CD1 File Offset: 0x00095ED1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005AAB RID: 23211
				// (get) Token: 0x06011720 RID: 71456 RVA: 0x004020A8 File Offset: 0x004002A8
				// (set) Token: 0x06011721 RID: 71457 RVA: 0x00097CDA File Offset: 0x00095EDA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005AAC RID: 23212
				// (get) Token: 0x06011722 RID: 71458 RVA: 0x004020D0 File Offset: 0x004002D0
				// (set) Token: 0x06011723 RID: 71459 RVA: 0x00097CF5 File Offset: 0x00095EF5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AAD RID: 23213
				// (get) Token: 0x06011724 RID: 71460 RVA: 0x00402100 File Offset: 0x00400300
				// (set) Token: 0x06011725 RID: 71461 RVA: 0x00097D14 File Offset: 0x00095F14
				public unsafe DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005AAE RID: 23214
				// (get) Token: 0x06011726 RID: 71462 RVA: 0x00402130 File Offset: 0x00400330
				// (set) Token: 0x06011727 RID: 71463 RVA: 0x00097D33 File Offset: 0x00095F33
				public unsafe WaitUntil _canContinueYieldInstruction_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__canContinueYieldInstruction_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__canContinueYieldInstruction_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B03E RID: 45118
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B03F RID: 45119
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B040 RID: 45120
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B041 RID: 45121
				private static readonly IntPtr NativeFieldInfoPtr__canContinueYieldInstruction_5__2;

				// Token: 0x0400B042 RID: 45122
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B043 RID: 45123
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B044 RID: 45124
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B045 RID: 45125
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B046 RID: 45126
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B047 RID: 45127
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200077F RID: 1919
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yuyuko+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A2A7 RID: 41639 RVA: 0x002AB6BC File Offset: 0x002A98BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9__12_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr, "<>9__12_6");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9__12_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr, "<>9__12_13");
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr, 100670157);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeMethodInfoPtr__EliteBossChallenge_b__12_6_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr, 100670158);
				DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeMethodInfoPtr__EliteBossChallenge_b__12_13_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr, 100670159);
			}

			// Token: 0x0600A2A8 RID: 41640 RVA: 0x002AB760 File Offset: 0x002A9960
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2A9 RID: 41641 RVA: 0x002AB79C File Offset: 0x002A999C
			[CallerCount(0)]
			public unsafe string _EliteBossChallenge_b__12_6(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeMethodInfoPtr__EliteBossChallenge_b__12_6_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600A2AA RID: 41642 RVA: 0x002AB7E4 File Offset: 0x002A99E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89976, XrefRangeEnd = 89980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EliteBossChallenge_b__12_13(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeMethodInfoPtr__EliteBossChallenge_b__12_13_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2AB RID: 41643 RVA: 0x00057E2F File Offset: 0x0005602F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035AE RID: 13742
			// (get) Token: 0x0600A2AC RID: 41644 RVA: 0x002AB828 File Offset: 0x002A9A28
			// (set) Token: 0x0600A2AD RID: 41645 RVA: 0x00057E38 File Offset: 0x00056038
			public unsafe static DLC5_RogueLikeEliteChallenge_Yuyuko.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yuyuko.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035AF RID: 13743
			// (get) Token: 0x0600A2AE RID: 41646 RVA: 0x002AB850 File Offset: 0x002A9A50
			// (set) Token: 0x0600A2AF RID: 41647 RVA: 0x00057E4A File Offset: 0x0005604A
			public unsafe static Func<string, string> __9__12_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9__12_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9__12_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035B0 RID: 13744
			// (get) Token: 0x0600A2B0 RID: 41648 RVA: 0x002AB878 File Offset: 0x002A9A78
			// (set) Token: 0x0600A2B1 RID: 41649 RVA: 0x00057E5C File Offset: 0x0005605C
			public unsafe static Action<TextMeshProUGUI> __9__12_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9__12_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeEliteChallenge_Yuyuko.__c.NativeFieldInfoPtr___9__12_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006954 RID: 26964
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006955 RID: 26965
			private static readonly IntPtr NativeFieldInfoPtr___9__12_6;

			// Token: 0x04006956 RID: 26966
			private static readonly IntPtr NativeFieldInfoPtr___9__12_13;

			// Token: 0x04006957 RID: 26967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006958 RID: 26968
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__12_6_Internal_String_String_0;

			// Token: 0x04006959 RID: 26969
			private static readonly IntPtr NativeMethodInfoPtr__EliteBossChallenge_b__12_13_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000780 RID: 1920
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteChallenge.DLC5_RogueLikeEliteChallenge_Yuyuko+<EliteBossSpellCardDeclaration>d__13")]
		public sealed class _EliteBossSpellCardDeclaration_d__13 : Il2CppSystem.Object
		{
			// Token: 0x0600A2B2 RID: 41650 RVA: 0x002AB8A0 File Offset: 0x002A9AA0
			// Note: this type is marked as 'beforefieldinit'.
			static _EliteBossSpellCardDeclaration_d__13()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko>.NativeClassPtr, "<EliteBossSpellCardDeclaration>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr);
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, "eventManager");
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, "runTimeData");
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, 100670160);
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, 100670161);
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, 100670162);
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, 100670163);
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, 100670164);
				DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr, 100670165);
			}

			// Token: 0x0600A2B3 RID: 41651 RVA: 0x002AB9A8 File Offset: 0x002A9BA8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EliteBossSpellCardDeclaration_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2B4 RID: 41652 RVA: 0x002AB9F0 File Offset: 0x002A9BF0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2B5 RID: 41653 RVA: 0x002ABA24 File Offset: 0x002A9C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89980, XrefRangeEnd = 89992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170035B6 RID: 13750
			// (get) Token: 0x0600A2B6 RID: 41654 RVA: 0x002ABA60 File Offset: 0x002A9C60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A2B7 RID: 41655 RVA: 0x002ABAA0 File Offset: 0x002A9CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89992, XrefRangeEnd = 89998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170035B7 RID: 13751
			// (get) Token: 0x0600A2B8 RID: 41656 RVA: 0x002ABAD4 File Offset: 0x002A9CD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A2B9 RID: 41657 RVA: 0x00057E6E File Offset: 0x0005606E
			public _EliteBossSpellCardDeclaration_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035B1 RID: 13745
			// (get) Token: 0x0600A2BA RID: 41658 RVA: 0x002ABB14 File Offset: 0x002A9D14
			// (set) Token: 0x0600A2BB RID: 41659 RVA: 0x00057E77 File Offset: 0x00056077
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170035B2 RID: 13746
			// (get) Token: 0x0600A2BC RID: 41660 RVA: 0x002ABB3C File Offset: 0x002A9D3C
			// (set) Token: 0x0600A2BD RID: 41661 RVA: 0x00057E92 File Offset: 0x00056092
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035B3 RID: 13747
			// (get) Token: 0x0600A2BE RID: 41662 RVA: 0x002ABB6C File Offset: 0x002A9D6C
			// (set) Token: 0x0600A2BF RID: 41663 RVA: 0x00057EB1 File Offset: 0x000560B1
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035B4 RID: 13748
			// (get) Token: 0x0600A2C0 RID: 41664 RVA: 0x002ABB9C File Offset: 0x002A9D9C
			// (set) Token: 0x0600A2C1 RID: 41665 RVA: 0x00057ED0 File Offset: 0x000560D0
			public unsafe DLC5_RogueLikeEliteChallenge_Yuyuko __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteChallenge_Yuyuko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035B5 RID: 13749
			// (get) Token: 0x0600A2C2 RID: 41666 RVA: 0x002ABBCC File Offset: 0x002A9DCC
			// (set) Token: 0x0600A2C3 RID: 41667 RVA: 0x00057EEF File Offset: 0x000560EF
			public unsafe RogueLikeRunTimeData runTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr_runTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteChallenge_Yuyuko._EliteBossSpellCardDeclaration_d__13.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400695A RID: 26970
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400695B RID: 26971
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400695C RID: 26972
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x0400695D RID: 26973
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400695E RID: 26974
			private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

			// Token: 0x0400695F RID: 26975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006960 RID: 26976
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006961 RID: 26977
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006962 RID: 26978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006963 RID: 26979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006964 RID: 26980
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
