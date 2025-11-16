using System;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.CookingUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000328 RID: 808
	public sealed class PartnerInfoSakuya : PartnerInfoBase
	{
		// Token: 0x06005F53 RID: 24403 RVA: 0x001DBB94 File Offset: 0x001D9D94
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoSakuya()
		{
			Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoSakuya");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr);
			PartnerInfoSakuya.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, "blinkDuration");
			PartnerInfoSakuya.NativeFieldInfoPtr_teleportEffectStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, "teleportEffectStart");
			PartnerInfoSakuya.NativeFieldInfoPtr_teleportEffectEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, "teleportEffectEnd");
			PartnerInfoSakuya.NativeFieldInfoPtr_sakuyaTeleportSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, "sakuyaTeleportSFX");
			PartnerInfoSakuya.NativeFieldInfoPtr_instantCook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, "instantCook");
			PartnerInfoSakuya.NativeMethodInfoPtr_MoveCharacter_Public_Virtual_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, 100682870);
			PartnerInfoSakuya.NativeMethodInfoPtr_ExternalStop_Public_Virtual_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, 100682871);
			PartnerInfoSakuya.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, 100682872);
			PartnerInfoSakuya.NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, 100682873);
			PartnerInfoSakuya.NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, 100682874);
			PartnerInfoSakuya.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, 100682875);
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x001DBCA0 File Offset: 0x001D9EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235467, XrefRangeEnd = 235487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveCharacter(AStarInputGeneratorComponent controlledCharacter, TileManager tileManager, Vector3Int dest, Vector3 extraOffset, DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation, Action onArrivalCallback, PartnerManager manager, bool useCollision, ref Il2CppSystem.Object additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlledCharacter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tileManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onArrivalRotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onArrivalCallback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCollision;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.NativeMethodInfoPtr_MoveCharacter_Public_Virtual_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			additionalData = ((intPtr4 == 0) ? null : new Il2CppSystem.Object(intPtr4));
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x001DBD7C File Offset: 0x001D9F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235487, XrefRangeEnd = 235492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExternalStop(AStarInputGeneratorComponent controlledCharacter, PartnerManager manager, ref Il2CppSystem.Object partnerMovementAdditionData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlledCharacter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(partnerMovementAdditionData);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.NativeMethodInfoPtr_ExternalStop_Public_Virtual_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			partnerMovementAdditionData = ((intPtr4 == 0) ? null : new Il2CppSystem.Object(intPtr4));
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x001DBDF8 File Offset: 0x001D9FF8
		[CallerCount(0)]
		public unsafe override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseSpeed, ref bool doNotCostIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &doNotCostIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x001DBE74 File Offset: 0x001DA074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235492, XrefRangeEnd = 235495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetMoveSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x001DBEAC File Offset: 0x001DA0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetWorkSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x001DBEE4 File Offset: 0x001DA0E4
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoSakuya() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x00033E7A File Offset: 0x0003207A
		public PartnerInfoSakuya(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06005F5B RID: 24411 RVA: 0x001DBF20 File Offset: 0x001DA120
		// (set) Token: 0x06005F5C RID: 24412 RVA: 0x00033E83 File Offset: 0x00032083
		public unsafe float blinkDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_blinkDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_blinkDuration)) = value;
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06005F5D RID: 24413 RVA: 0x001DBF48 File Offset: 0x001DA148
		// (set) Token: 0x06005F5E RID: 24414 RVA: 0x00033E9E File Offset: 0x0003209E
		public unsafe GameObject teleportEffectStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_teleportEffectStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_teleportEffectStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06005F5F RID: 24415 RVA: 0x001DBF78 File Offset: 0x001DA178
		// (set) Token: 0x06005F60 RID: 24416 RVA: 0x00033EBD File Offset: 0x000320BD
		public unsafe GameObject teleportEffectEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_teleportEffectEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_teleportEffectEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06005F61 RID: 24417 RVA: 0x001DBFA8 File Offset: 0x001DA1A8
		// (set) Token: 0x06005F62 RID: 24418 RVA: 0x00033EDC File Offset: 0x000320DC
		public unsafe AudioClip sakuyaTeleportSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_sakuyaTeleportSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_sakuyaTeleportSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06005F63 RID: 24419 RVA: 0x001DBFD8 File Offset: 0x001DA1D8
		// (set) Token: 0x06005F64 RID: 24420 RVA: 0x00033EFB File Offset: 0x000320FB
		public unsafe bool instantCook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_instantCook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.NativeFieldInfoPtr_instantCook)) = value;
			}
		}

		// Token: 0x04003F0C RID: 16140
		private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

		// Token: 0x04003F0D RID: 16141
		private static readonly IntPtr NativeFieldInfoPtr_teleportEffectStart;

		// Token: 0x04003F0E RID: 16142
		private static readonly IntPtr NativeFieldInfoPtr_teleportEffectEnd;

		// Token: 0x04003F0F RID: 16143
		private static readonly IntPtr NativeFieldInfoPtr_sakuyaTeleportSFX;

		// Token: 0x04003F10 RID: 16144
		private static readonly IntPtr NativeFieldInfoPtr_instantCook;

		// Token: 0x04003F11 RID: 16145
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacter_Public_Virtual_Void_AStarInputGeneratorComponent_TileManager_Vector3Int_Vector3_CharacterRotation_Action_PartnerManager_Boolean_byref_Object_0;

		// Token: 0x04003F12 RID: 16146
		private static readonly IntPtr NativeMethodInfoPtr_ExternalStop_Public_Virtual_Void_AStarInputGeneratorComponent_PartnerManager_byref_Object_0;

		// Token: 0x04003F13 RID: 16147
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0;

		// Token: 0x04003F14 RID: 16148
		private static readonly IntPtr NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0;

		// Token: 0x04003F15 RID: 16149
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0;

		// Token: 0x04003F16 RID: 16150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D58 RID: 3416
		[ObfuscatedName("GameData.Profile.PartnerInfoSakuya+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F4B7 RID: 62647 RVA: 0x0039D9C0 File Offset: 0x0039BBC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoSakuya>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr);
				PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_controlledCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, "controlledCharacter");
				PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, "dest");
				PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_extraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, "extraOffset");
				PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_onArrivalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, "onArrivalRotation");
				PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_onArrivalCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, "onArrivalCallback");
				PartnerInfoSakuya.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, 100682876);
				PartnerInfoSakuya.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, 100682877);
			}

			// Token: 0x0600F4B8 RID: 62648 RVA: 0x0039DA8C File Offset: 0x0039BC8C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4B9 RID: 62649 RVA: 0x0039DAC8 File Offset: 0x0039BCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235462, XrefRangeEnd = 235467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F4BA RID: 62650 RVA: 0x0008368A File Offset: 0x0008188A
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F8C RID: 20364
			// (get) Token: 0x0600F4BB RID: 62651 RVA: 0x0039DB08 File Offset: 0x0039BD08
			// (set) Token: 0x0600F4BC RID: 62652 RVA: 0x00083693 File Offset: 0x00081893
			public unsafe AStarInputGeneratorComponent controlledCharacter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_controlledCharacter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_controlledCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F8D RID: 20365
			// (get) Token: 0x0600F4BD RID: 62653 RVA: 0x0039DB38 File Offset: 0x0039BD38
			// (set) Token: 0x0600F4BE RID: 62654 RVA: 0x000836B2 File Offset: 0x000818B2
			public unsafe Vector3Int dest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_dest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_dest)) = value;
				}
			}

			// Token: 0x17004F8E RID: 20366
			// (get) Token: 0x0600F4BF RID: 62655 RVA: 0x0039DB60 File Offset: 0x0039BD60
			// (set) Token: 0x0600F4C0 RID: 62656 RVA: 0x000836CD File Offset: 0x000818CD
			public unsafe Vector3 extraOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_extraOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_extraOffset)) = value;
				}
			}

			// Token: 0x17004F8F RID: 20367
			// (get) Token: 0x0600F4C1 RID: 62657 RVA: 0x0039DB88 File Offset: 0x0039BD88
			// (set) Token: 0x0600F4C2 RID: 62658 RVA: 0x000836E8 File Offset: 0x000818E8
			public unsafe PartnerInfoSakuya __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSakuya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F90 RID: 20368
			// (get) Token: 0x0600F4C3 RID: 62659 RVA: 0x0039DBB8 File Offset: 0x0039BDB8
			// (set) Token: 0x0600F4C4 RID: 62660 RVA: 0x00083707 File Offset: 0x00081907
			public unsafe DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_onArrivalRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_onArrivalRotation)) = value;
				}
			}

			// Token: 0x17004F91 RID: 20369
			// (get) Token: 0x0600F4C5 RID: 62661 RVA: 0x0039DBE0 File Offset: 0x0039BDE0
			// (set) Token: 0x0600F4C6 RID: 62662 RVA: 0x00083722 File Offset: 0x00081922
			public unsafe Action onArrivalCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_onArrivalCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.NativeFieldInfoPtr_onArrivalCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BE2 RID: 39906
			private static readonly IntPtr NativeFieldInfoPtr_controlledCharacter;

			// Token: 0x04009BE3 RID: 39907
			private static readonly IntPtr NativeFieldInfoPtr_dest;

			// Token: 0x04009BE4 RID: 39908
			private static readonly IntPtr NativeFieldInfoPtr_extraOffset;

			// Token: 0x04009BE5 RID: 39909
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BE6 RID: 39910
			private static readonly IntPtr NativeFieldInfoPtr_onArrivalRotation;

			// Token: 0x04009BE7 RID: 39911
			private static readonly IntPtr NativeFieldInfoPtr_onArrivalCallback;

			// Token: 0x04009BE8 RID: 39912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BE9 RID: 39913
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200109A RID: 4250
			[ObfuscatedName("GameData.Profile.PartnerInfoSakuya+<>c__DisplayClass5_0+<<MoveCharacter>g__OnBlinkDelay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601219E RID: 74142 RVA: 0x004218A0 File Offset: 0x0041FAA0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique()
				{
					Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0>.NativeClassPtr, "<<MoveCharacter>g__OnBlinkDelay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr);
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, "<>1__state");
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, "<>2__current");
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, "<>4__this");
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, "<startPosition>5__2");
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr__targetPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, "<targetPosition>5__3");
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, 100682878);
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, 100682879);
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, 100682880);
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, 100682881);
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, 100682882);
					PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr, 100682883);
				}

				// Token: 0x0601219F RID: 74143 RVA: 0x004219A8 File Offset: 0x0041FBA8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121A0 RID: 74144 RVA: 0x004219F0 File Offset: 0x0041FBF0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121A1 RID: 74145 RVA: 0x00421A24 File Offset: 0x0041FC24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235431, XrefRangeEnd = 235456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E8B RID: 24203
				// (get) Token: 0x060121A2 RID: 74146 RVA: 0x00421A60 File Offset: 0x0041FC60
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121A3 RID: 74147 RVA: 0x00421AA0 File Offset: 0x0041FCA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235456, XrefRangeEnd = 235462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E8C RID: 24204
				// (get) Token: 0x060121A4 RID: 74148 RVA: 0x00421AD4 File Offset: 0x0041FCD4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121A5 RID: 74149 RVA: 0x0009D463 File Offset: 0x0009B663
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E86 RID: 24198
				// (get) Token: 0x060121A6 RID: 74150 RVA: 0x00421B14 File Offset: 0x0041FD14
				// (set) Token: 0x060121A7 RID: 74151 RVA: 0x0009D46C File Offset: 0x0009B66C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E87 RID: 24199
				// (get) Token: 0x060121A8 RID: 74152 RVA: 0x00421B3C File Offset: 0x0041FD3C
				// (set) Token: 0x060121A9 RID: 74153 RVA: 0x0009D487 File Offset: 0x0009B687
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E88 RID: 24200
				// (get) Token: 0x060121AA RID: 74154 RVA: 0x00421B6C File Offset: 0x0041FD6C
				// (set) Token: 0x060121AB RID: 74155 RVA: 0x0009D4A6 File Offset: 0x0009B6A6
				public unsafe PartnerInfoSakuya.__c__DisplayClass5_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSakuya.__c__DisplayClass5_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E89 RID: 24201
				// (get) Token: 0x060121AC RID: 74156 RVA: 0x00421B9C File Offset: 0x0041FD9C
				// (set) Token: 0x060121AD RID: 74157 RVA: 0x0009D4C5 File Offset: 0x0009B6C5
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x17005E8A RID: 24202
				// (get) Token: 0x060121AE RID: 74158 RVA: 0x00421BC4 File Offset: 0x0041FDC4
				// (set) Token: 0x060121AF RID: 74159 RVA: 0x0009D4E0 File Offset: 0x0009B6E0
				public unsafe Vector3 _targetPosition_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr__targetPosition_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSakuya.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVeObObUnique.NativeFieldInfoPtr__targetPosition_5__3)) = value;
					}
				}

				// Token: 0x0400B767 RID: 46951
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B768 RID: 46952
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B769 RID: 46953
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B76A RID: 46954
				private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x0400B76B RID: 46955
				private static readonly IntPtr NativeFieldInfoPtr__targetPosition_5__3;

				// Token: 0x0400B76C RID: 46956
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B76D RID: 46957
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B76E RID: 46958
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B76F RID: 46959
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B770 RID: 46960
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B771 RID: 46961
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
