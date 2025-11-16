using System;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using NightScene.UI;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002F5 RID: 757
	public class BossData : ScriptableObject
	{
		// Token: 0x06005A72 RID: 23154 RVA: 0x001CD5B4 File Offset: 0x001CB7B4
		// Note: this type is marked as 'beforefieldinit'.
		static BossData()
		{
			Il2CppClassPointerStore<BossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "BossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossData>.NativeClassPtr);
			BossData.NativeFieldInfoPtr_CORE_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "CORE_KEY");
			BossData.NativeFieldInfoPtr_DLC1_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "DLC1_KEY");
			BossData.NativeFieldInfoPtr_DLC2_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "DLC2_KEY");
			BossData.NativeFieldInfoPtr_DLC3_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "DLC3_KEY");
			BossData.NativeFieldInfoPtr_DLC4_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "DLC4_KEY");
			BossData.NativeFieldInfoPtr_DLC_MUSIC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "DLC_MUSIC_KEY");
			BossData.NativeFieldInfoPtr_doNotMakePassionEffectMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "doNotMakePassionEffectMusic");
			BossData.NativeFieldInfoPtr_startPassion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "startPassion");
			BossData.NativeFieldInfoPtr_bossStatusUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "bossStatusUI");
			BossData.NativeFieldInfoPtr_useGhostCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData>.NativeClassPtr, "useGhostCharacter");
			BossData.NativeMethodInfoPtr_get_UseGhostCharacter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossData>.NativeClassPtr, 100681445);
			BossData.NativeMethodInfoPtr_GotoBossChallengeScene_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossData>.NativeClassPtr, 100681446);
			BossData.NativeMethodInfoPtr_get_OneSecondDelay_Protected_get_WaitForSeconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossData>.NativeClassPtr, 100681447);
			BossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Abstract_Virtual_New_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossData>.NativeClassPtr, 100681448);
			BossData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossData>.NativeClassPtr, 100681449);
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06005A73 RID: 23155 RVA: 0x001CD710 File Offset: 0x001CB910
		public unsafe bool UseGhostCharacter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BossData.NativeMethodInfoPtr_get_UseGhostCharacter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x001CD74C File Offset: 0x001CB94C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GotoBossChallengeScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BossData.NativeMethodInfoPtr_GotoBossChallengeScene_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06005A75 RID: 23157 RVA: 0x001CD788 File Offset: 0x001CB988
		public unsafe WaitForSeconds OneSecondDelay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220012, XrefRangeEnd = 220016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BossData.NativeMethodInfoPtr_get_OneSecondDelay_Protected_get_WaitForSeconds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr3) : null;
			}
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x001CD7C8 File Offset: 0x001CB9C8
		[CallerCount(0)]
		public unsafe virtual IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Abstract_Virtual_New_IEnumerator_BossDataContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x001CD828 File Offset: 0x001CBA28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220017, RefRangeEnd = 220023, XrefRangeStart = 220016, XrefRangeEnd = 220017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BossData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00030E1C File Offset: 0x0002F01C
		public BossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06005A79 RID: 23161 RVA: 0x001CD864 File Offset: 0x001CBA64
		// (set) Token: 0x06005A7A RID: 23162 RVA: 0x00030E25 File Offset: 0x0002F025
		public unsafe static string CORE_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BossData.NativeFieldInfoPtr_CORE_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BossData.NativeFieldInfoPtr_CORE_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06005A7B RID: 23163 RVA: 0x001CD884 File Offset: 0x001CBA84
		// (set) Token: 0x06005A7C RID: 23164 RVA: 0x00030E37 File Offset: 0x0002F037
		public unsafe static string DLC1_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BossData.NativeFieldInfoPtr_DLC1_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BossData.NativeFieldInfoPtr_DLC1_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06005A7D RID: 23165 RVA: 0x001CD8A4 File Offset: 0x001CBAA4
		// (set) Token: 0x06005A7E RID: 23166 RVA: 0x00030E49 File Offset: 0x0002F049
		public unsafe static string DLC2_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BossData.NativeFieldInfoPtr_DLC2_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BossData.NativeFieldInfoPtr_DLC2_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06005A7F RID: 23167 RVA: 0x001CD8C4 File Offset: 0x001CBAC4
		// (set) Token: 0x06005A80 RID: 23168 RVA: 0x00030E5B File Offset: 0x0002F05B
		public unsafe static string DLC3_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BossData.NativeFieldInfoPtr_DLC3_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BossData.NativeFieldInfoPtr_DLC3_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x06005A81 RID: 23169 RVA: 0x001CD8E4 File Offset: 0x001CBAE4
		// (set) Token: 0x06005A82 RID: 23170 RVA: 0x00030E6D File Offset: 0x0002F06D
		public unsafe static string DLC4_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BossData.NativeFieldInfoPtr_DLC4_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BossData.NativeFieldInfoPtr_DLC4_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x06005A83 RID: 23171 RVA: 0x001CD904 File Offset: 0x001CBB04
		// (set) Token: 0x06005A84 RID: 23172 RVA: 0x00030E7F File Offset: 0x0002F07F
		public unsafe static string DLC_MUSIC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BossData.NativeFieldInfoPtr_DLC_MUSIC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BossData.NativeFieldInfoPtr_DLC_MUSIC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x06005A85 RID: 23173 RVA: 0x001CD924 File Offset: 0x001CBB24
		// (set) Token: 0x06005A86 RID: 23174 RVA: 0x00030E91 File Offset: 0x0002F091
		public unsafe bool doNotMakePassionEffectMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.NativeFieldInfoPtr_doNotMakePassionEffectMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.NativeFieldInfoPtr_doNotMakePassionEffectMusic)) = value;
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x06005A87 RID: 23175 RVA: 0x001CD94C File Offset: 0x001CBB4C
		// (set) Token: 0x06005A88 RID: 23176 RVA: 0x00030EAC File Offset: 0x0002F0AC
		public unsafe int startPassion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.NativeFieldInfoPtr_startPassion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.NativeFieldInfoPtr_startPassion)) = value;
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06005A89 RID: 23177 RVA: 0x001CD974 File Offset: 0x001CBB74
		// (set) Token: 0x06005A8A RID: 23178 RVA: 0x00030EC7 File Offset: 0x0002F0C7
		public unsafe GameObject bossStatusUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.NativeFieldInfoPtr_bossStatusUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.NativeFieldInfoPtr_bossStatusUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06005A8B RID: 23179 RVA: 0x001CD9A4 File Offset: 0x001CBBA4
		// (set) Token: 0x06005A8C RID: 23180 RVA: 0x00030EE6 File Offset: 0x0002F0E6
		public unsafe bool useGhostCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.NativeFieldInfoPtr_useGhostCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.NativeFieldInfoPtr_useGhostCharacter)) = value;
			}
		}

		// Token: 0x04003C30 RID: 15408
		private static readonly IntPtr NativeFieldInfoPtr_CORE_KEY;

		// Token: 0x04003C31 RID: 15409
		private static readonly IntPtr NativeFieldInfoPtr_DLC1_KEY;

		// Token: 0x04003C32 RID: 15410
		private static readonly IntPtr NativeFieldInfoPtr_DLC2_KEY;

		// Token: 0x04003C33 RID: 15411
		private static readonly IntPtr NativeFieldInfoPtr_DLC3_KEY;

		// Token: 0x04003C34 RID: 15412
		private static readonly IntPtr NativeFieldInfoPtr_DLC4_KEY;

		// Token: 0x04003C35 RID: 15413
		private static readonly IntPtr NativeFieldInfoPtr_DLC_MUSIC_KEY;

		// Token: 0x04003C36 RID: 15414
		private static readonly IntPtr NativeFieldInfoPtr_doNotMakePassionEffectMusic;

		// Token: 0x04003C37 RID: 15415
		private static readonly IntPtr NativeFieldInfoPtr_startPassion;

		// Token: 0x04003C38 RID: 15416
		private static readonly IntPtr NativeFieldInfoPtr_bossStatusUI;

		// Token: 0x04003C39 RID: 15417
		private static readonly IntPtr NativeFieldInfoPtr_useGhostCharacter;

		// Token: 0x04003C3A RID: 15418
		private static readonly IntPtr NativeMethodInfoPtr_get_UseGhostCharacter_Public_get_Boolean_0;

		// Token: 0x04003C3B RID: 15419
		private static readonly IntPtr NativeMethodInfoPtr_GotoBossChallengeScene_Public_Virtual_New_Void_0;

		// Token: 0x04003C3C RID: 15420
		private static readonly IntPtr NativeMethodInfoPtr_get_OneSecondDelay_Protected_get_WaitForSeconds_0;

		// Token: 0x04003C3D RID: 15421
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Abstract_Virtual_New_IEnumerator_BossDataContext_0;

		// Token: 0x04003C3E RID: 15422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000CBB RID: 3259
		public sealed class BossDataContext : ValueType
		{
			// Token: 0x0600E946 RID: 59718 RVA: 0x0037C664 File Offset: 0x0037A864
			// Note: this type is marked as 'beforefieldinit'.
			static BossDataContext()
			{
				Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BossData>.NativeClassPtr, "BossDataContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr);
				BossData.BossDataContext.NativeFieldInfoPtr_EventManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "EventManagerInstance");
				BossData.BossDataContext.NativeFieldInfoPtr_UIManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "UIManagerInstance");
				BossData.BossDataContext.NativeFieldInfoPtr_GuestsManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "GuestsManagerInstance");
				BossData.BossDataContext.NativeFieldInfoPtr_CookSystemManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "CookSystemManagerInstance");
				BossData.BossDataContext.NativeFieldInfoPtr_IzakayaConfigureInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "IzakayaConfigureInstance");
				BossData.BossDataContext.NativeFieldInfoPtr_PartnerManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "PartnerManagerInstance");
				BossData.BossDataContext.NativeFieldInfoPtr_TileManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "TileManagerInstance");
				BossData.BossDataContext.NativeFieldInfoPtr_SceneManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "SceneManager");
				BossData.BossDataContext.NativeFieldInfoPtr_QTEManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, "QTEManager");
				BossData.BossDataContext.NativeMethodInfoPtr__ctor_Public_Void_EventManager_UIManager_GuestsManager_IzakayaConfigure_CookSystemManager_PartnerManager_TileManager_SceneManager_QTERewardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, 100681450);
			}

			// Token: 0x0600E947 RID: 59719 RVA: 0x0037C758 File Offset: 0x0037A958
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 220011, RefRangeEnd = 220012, XrefRangeStart = 220002, XrefRangeEnd = 220011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BossDataContext(EventManager eventManagerInstance, UIManager uIManagerInstance, GuestsManager guestsManagerInstance, IzakayaConfigure izakayaConfigureInstance, CookSystemManager cookSystemManagerInstance, PartnerManager partnerManagerInstance, TileManager tileManagerInstance, SceneManager sceneManager, QTERewardManager qteManager) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManagerInstance);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uIManagerInstance);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestsManagerInstance);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakayaConfigureInstance);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookSystemManagerInstance);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManagerInstance);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tileManagerInstance);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sceneManager);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qteManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BossData.BossDataContext.NativeMethodInfoPtr__ctor_Public_Void_EventManager_UIManager_GuestsManager_IzakayaConfigure_CookSystemManager_PartnerManager_TileManager_SceneManager_QTERewardManager_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E948 RID: 59720 RVA: 0x0007CCB2 File Offset: 0x0007AEB2
			public BossDataContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E949 RID: 59721 RVA: 0x0007CCBB File Offset: 0x0007AEBB
			public BossDataContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr))
			{
			}

			// Token: 0x17004BD6 RID: 19414
			// (get) Token: 0x0600E94A RID: 59722 RVA: 0x0037C840 File Offset: 0x0037AA40
			// (set) Token: 0x0600E94B RID: 59723 RVA: 0x0007CCCD File Offset: 0x0007AECD
			public unsafe EventManager EventManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_EventManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_EventManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD7 RID: 19415
			// (get) Token: 0x0600E94C RID: 59724 RVA: 0x0037C870 File Offset: 0x0037AA70
			// (set) Token: 0x0600E94D RID: 59725 RVA: 0x0007CCEC File Offset: 0x0007AEEC
			public unsafe UIManager UIManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_UIManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_UIManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD8 RID: 19416
			// (get) Token: 0x0600E94E RID: 59726 RVA: 0x0037C8A0 File Offset: 0x0037AAA0
			// (set) Token: 0x0600E94F RID: 59727 RVA: 0x0007CD0B File Offset: 0x0007AF0B
			public unsafe GuestsManager GuestsManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_GuestsManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_GuestsManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD9 RID: 19417
			// (get) Token: 0x0600E950 RID: 59728 RVA: 0x0037C8D0 File Offset: 0x0037AAD0
			// (set) Token: 0x0600E951 RID: 59729 RVA: 0x0007CD2A File Offset: 0x0007AF2A
			public unsafe CookSystemManager CookSystemManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_CookSystemManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_CookSystemManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BDA RID: 19418
			// (get) Token: 0x0600E952 RID: 59730 RVA: 0x0037C900 File Offset: 0x0037AB00
			// (set) Token: 0x0600E953 RID: 59731 RVA: 0x0007CD49 File Offset: 0x0007AF49
			public unsafe IzakayaConfigure IzakayaConfigureInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_IzakayaConfigureInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_IzakayaConfigureInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BDB RID: 19419
			// (get) Token: 0x0600E954 RID: 59732 RVA: 0x0037C930 File Offset: 0x0037AB30
			// (set) Token: 0x0600E955 RID: 59733 RVA: 0x0007CD68 File Offset: 0x0007AF68
			public unsafe PartnerManager PartnerManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_PartnerManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_PartnerManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BDC RID: 19420
			// (get) Token: 0x0600E956 RID: 59734 RVA: 0x0037C960 File Offset: 0x0037AB60
			// (set) Token: 0x0600E957 RID: 59735 RVA: 0x0007CD87 File Offset: 0x0007AF87
			public unsafe TileManager TileManagerInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_TileManagerInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_TileManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BDD RID: 19421
			// (get) Token: 0x0600E958 RID: 59736 RVA: 0x0037C990 File Offset: 0x0037AB90
			// (set) Token: 0x0600E959 RID: 59737 RVA: 0x0007CDA6 File Offset: 0x0007AFA6
			public unsafe SceneManager SceneManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_SceneManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_SceneManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BDE RID: 19422
			// (get) Token: 0x0600E95A RID: 59738 RVA: 0x0037C9C0 File Offset: 0x0037ABC0
			// (set) Token: 0x0600E95B RID: 59739 RVA: 0x0007CDC5 File Offset: 0x0007AFC5
			public unsafe QTERewardManager QTEManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_QTEManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTERewardManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BossData.BossDataContext.NativeFieldInfoPtr_QTEManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094CD RID: 38093
			private static readonly IntPtr NativeFieldInfoPtr_EventManagerInstance;

			// Token: 0x040094CE RID: 38094
			private static readonly IntPtr NativeFieldInfoPtr_UIManagerInstance;

			// Token: 0x040094CF RID: 38095
			private static readonly IntPtr NativeFieldInfoPtr_GuestsManagerInstance;

			// Token: 0x040094D0 RID: 38096
			private static readonly IntPtr NativeFieldInfoPtr_CookSystemManagerInstance;

			// Token: 0x040094D1 RID: 38097
			private static readonly IntPtr NativeFieldInfoPtr_IzakayaConfigureInstance;

			// Token: 0x040094D2 RID: 38098
			private static readonly IntPtr NativeFieldInfoPtr_PartnerManagerInstance;

			// Token: 0x040094D3 RID: 38099
			private static readonly IntPtr NativeFieldInfoPtr_TileManagerInstance;

			// Token: 0x040094D4 RID: 38100
			private static readonly IntPtr NativeFieldInfoPtr_SceneManager;

			// Token: 0x040094D5 RID: 38101
			private static readonly IntPtr NativeFieldInfoPtr_QTEManager;

			// Token: 0x040094D6 RID: 38102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventManager_UIManager_GuestsManager_IzakayaConfigure_CookSystemManager_PartnerManager_TileManager_SceneManager_QTERewardManager_0;
		}
	}
}
