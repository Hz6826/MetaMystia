using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020001A7 RID: 423
	public class GuestIconManager : Il2CppSystem.Object
	{
		// Token: 0x06002F7F RID: 12159 RVA: 0x0013CF7C File Offset: 0x0013B17C
		// Note: this type is marked as 'beforefieldinit'.
		static GuestIconManager()
		{
			Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.GuestManagementUtility", "GuestIconManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr);
			GuestIconManager.NativeFieldInfoPtr_STATE_ICON_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "STATE_ICON_OFFSET");
			GuestIconManager.NativeFieldInfoPtr_awaitPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "awaitPrototype");
			GuestIconManager.NativeFieldInfoPtr_eatPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "eatPrototype");
			GuestIconManager.NativeFieldInfoPtr_serveInWorkMissionPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "serveInWorkMissionPrototype");
			GuestIconManager.NativeFieldInfoPtr_guestIconBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "guestIconBuffer");
			GuestIconManager.NativeFieldInfoPtr_guests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "guests");
			GuestIconManager.NativeFieldInfoPtr_hateFoodTagAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "hateFoodTagAudio");
			GuestIconManager.NativeFieldInfoPtr_hateFoodTagPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "hateFoodTagPrototype");
			GuestIconManager.NativeFieldInfoPtr_iconOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "iconOffset");
			GuestIconManager.NativeFieldInfoPtr_uiContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "uiContainer");
			GuestIconManager.NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_Canvas_GameObject_GameObject_GameObject_GameObject_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671643);
			GuestIconManager.NativeMethodInfoPtr_UpdateIcon_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671644);
			GuestIconManager.NativeMethodInfoPtr_Add_Public_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671645);
			GuestIconManager.NativeMethodInfoPtr_Remove_Public_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671646);
			GuestIconManager.NativeMethodInfoPtr_SwitchState_Public_Void_GuestGroupController_GuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671647);
			GuestIconManager.NativeMethodInfoPtr_ShowHateFoodTag_Public_Void_GuestGroupController_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671648);
			GuestIconManager.NativeMethodInfoPtr_InstantiateGameObjects_Private_Void_byref_GuestIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671649);
			GuestIconManager.NativeMethodInfoPtr_SetGameObjectsActive_Private_Void_Il2CppReferenceArray_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671650);
			GuestIconManager.NativeMethodInfoPtr_SetGameObjectsPosition_Private_Void_Il2CppReferenceArray_1_GameObject_GuestGroupController_GuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671651);
			GuestIconManager.NativeMethodInfoPtr_DestroyGameObjects_Private_Void_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671652);
			GuestIconManager.NativeMethodInfoPtr_WorldPositionToUIPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, 100671653);
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x0013D150 File Offset: 0x0013B350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105510, RefRangeEnd = 105511, XrefRangeStart = 105480, XrefRangeEnd = 105510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestIconManager(MonoBehaviour monoBehaviour, Canvas uiContainer, GameObject awaitPrototype, GameObject eatPrototype, GameObject serveInWorkMissionPrototype, GameObject hateFoodTagPrototype, AudioClip hateFoodTagAudio) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(monoBehaviour);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiContainer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(awaitPrototype);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eatPrototype);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serveInWorkMissionPrototype);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hateFoodTagPrototype);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hateFoodTagAudio);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_Canvas_GameObject_GameObject_GameObject_GameObject_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x0013D20C File Offset: 0x0013B40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105511, XrefRangeEnd = 105516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_UpdateIcon_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x0013D24C File Offset: 0x0013B44C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 105540, RefRangeEnd = 105544, XrefRangeStart = 105516, XrefRangeEnd = 105540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_Add_Public_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x0013D290 File Offset: 0x0013B490
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 105562, RefRangeEnd = 105569, XrefRangeStart = 105544, XrefRangeEnd = 105562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_Remove_Public_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x0013D2E0 File Offset: 0x0013B4E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 105594, RefRangeEnd = 105598, XrefRangeStart = 105569, XrefRangeEnd = 105594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchState(GuestGroupController guestGroupController, GuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_SwitchState_Public_Void_GuestGroupController_GuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x0013D330 File Offset: 0x0013B530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105598, XrefRangeEnd = 105636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHateFoodTag(GuestGroupController guestGroupController, string tagName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tagName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_ShowHateFoodTag_Public_Void_GuestGroupController_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0013D384 File Offset: 0x0013B584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105652, RefRangeEnd = 105654, XrefRangeStart = 105636, XrefRangeEnd = 105652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateGameObjects(ref GuestIcon guestIcon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(guestIcon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_InstantiateGameObjects_Private_Void_byref_GuestIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x0013D3C8 File Offset: 0x0013B5C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 105660, RefRangeEnd = 105663, XrefRangeStart = 105654, XrefRangeEnd = 105660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameObjectsActive(Il2CppReferenceArray<GameObject> gameObjects, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_SetGameObjectsActive_Private_Void_Il2CppReferenceArray_1_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x0013D418 File Offset: 0x0013B618
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 105680, RefRangeEnd = 105682, XrefRangeStart = 105663, XrefRangeEnd = 105680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameObjectsPosition(Il2CppReferenceArray<GameObject> gameObjects, GuestGroupController guestGroupController, GuestState guestState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_SetGameObjectsPosition_Private_Void_Il2CppReferenceArray_1_GameObject_GuestGroupController_GuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x0013D47C File Offset: 0x0013B67C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 105691, RefRangeEnd = 105694, XrefRangeStart = 105682, XrefRangeEnd = 105691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyGameObjects(Il2CppReferenceArray<GameObject> gameObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_DestroyGameObjects_Private_Void_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x0013D4C0 File Offset: 0x0013B6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105694, XrefRangeEnd = 105696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldPositionToUIPosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager.NativeMethodInfoPtr_WorldPositionToUIPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x0001B3BE File Offset: 0x000195BE
		public GuestIconManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x0013D50C File Offset: 0x0013B70C
		// (set) Token: 0x06002F8D RID: 12173 RVA: 0x0001B3C7 File Offset: 0x000195C7
		public unsafe static float STATE_ICON_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GuestIconManager.NativeFieldInfoPtr_STATE_ICON_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GuestIconManager.NativeFieldInfoPtr_STATE_ICON_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x0013D528 File Offset: 0x0013B728
		// (set) Token: 0x06002F8F RID: 12175 RVA: 0x0001B3D5 File Offset: 0x000195D5
		public unsafe GameObject awaitPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_awaitPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_awaitPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x0013D558 File Offset: 0x0013B758
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x0001B3F4 File Offset: 0x000195F4
		public unsafe GameObject eatPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_eatPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_eatPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x0013D588 File Offset: 0x0013B788
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x0001B413 File Offset: 0x00019613
		public unsafe GameObject serveInWorkMissionPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_serveInWorkMissionPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_serveInWorkMissionPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x0013D5B8 File Offset: 0x0013B7B8
		// (set) Token: 0x06002F95 RID: 12181 RVA: 0x0001B432 File Offset: 0x00019632
		public unsafe Dictionary<GuestGroupController, List<GuestIconOverride>> guestIconBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_guestIconBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GuestGroupController, List<GuestIconOverride>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_guestIconBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x0013D5E8 File Offset: 0x0013B7E8
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x0001B451 File Offset: 0x00019651
		public unsafe Dictionary<GuestGroupController, GuestIcon> guests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_guests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GuestGroupController, GuestIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_guests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x0013D618 File Offset: 0x0013B818
		// (set) Token: 0x06002F99 RID: 12185 RVA: 0x0001B470 File Offset: 0x00019670
		public unsafe AudioClip hateFoodTagAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_hateFoodTagAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_hateFoodTagAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x0013D648 File Offset: 0x0013B848
		// (set) Token: 0x06002F9B RID: 12187 RVA: 0x0001B48F File Offset: 0x0001968F
		public unsafe GameObject hateFoodTagPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_hateFoodTagPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_hateFoodTagPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x0013D678 File Offset: 0x0013B878
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x0001B4AE File Offset: 0x000196AE
		public unsafe Vector3 iconOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_iconOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_iconOffset)) = value;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x0013D6A0 File Offset: 0x0013B8A0
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x0001B4C9 File Offset: 0x000196C9
		public unsafe Canvas uiContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_uiContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager.NativeFieldInfoPtr_uiContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeFieldInfoPtr_STATE_ICON_OFFSET;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeFieldInfoPtr_awaitPrototype;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeFieldInfoPtr_eatPrototype;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeFieldInfoPtr_serveInWorkMissionPrototype;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr_guestIconBuffer;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeFieldInfoPtr_guests;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeFieldInfoPtr_hateFoodTagAudio;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr_hateFoodTagPrototype;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_iconOffset;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_uiContainer;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_Canvas_GameObject_GameObject_GameObject_GameObject_AudioClip_0;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIcon_Private_IEnumerator_0;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GuestGroupController_0;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_GuestGroupController_0;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr_SwitchState_Public_Void_GuestGroupController_GuestState_0;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeMethodInfoPtr_ShowHateFoodTag_Public_Void_GuestGroupController_String_0;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGameObjects_Private_Void_byref_GuestIcon_0;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeMethodInfoPtr_SetGameObjectsActive_Private_Void_Il2CppReferenceArray_1_GameObject_Boolean_0;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeMethodInfoPtr_SetGameObjectsPosition_Private_Void_Il2CppReferenceArray_1_GameObject_GuestGroupController_GuestState_0;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeMethodInfoPtr_DestroyGameObjects_Private_Void_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeMethodInfoPtr_WorldPositionToUIPosition_Private_Vector3_Vector3_0;

		// Token: 0x02000825 RID: 2085
		[ObfuscatedName("NightScene.GuestManagementUtility.GuestIconManager+<UpdateIcon>d__11")]
		public sealed class _UpdateIcon_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600AA52 RID: 43602 RVA: 0x002C1984 File Offset: 0x002BFB84
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateIcon_d__11()
			{
				Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestIconManager>.NativeClassPtr, "<UpdateIcon>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr);
				GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, "<>1__state");
				GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, "<>2__current");
				GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, "<>4__this");
				GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, 100671654);
				GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, 100671655);
				GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, 100671656);
				GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, 100671657);
				GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, 100671658);
				GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr, 100671659);
			}

			// Token: 0x0600AA53 RID: 43603 RVA: 0x002C1A64 File Offset: 0x002BFC64
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateIcon_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestIconManager._UpdateIcon_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AA54 RID: 43604 RVA: 0x002C1AAC File Offset: 0x002BFCAC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AA55 RID: 43605 RVA: 0x002C1AE0 File Offset: 0x002BFCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105414, XrefRangeEnd = 105474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170037E9 RID: 14313
			// (get) Token: 0x0600AA56 RID: 43606 RVA: 0x002C1B1C File Offset: 0x002BFD1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AA57 RID: 43607 RVA: 0x002C1B5C File Offset: 0x002BFD5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105474, XrefRangeEnd = 105480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170037EA RID: 14314
			// (get) Token: 0x0600AA58 RID: 43608 RVA: 0x002C1B90 File Offset: 0x002BFD90
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestIconManager._UpdateIcon_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AA59 RID: 43609 RVA: 0x0005BD75 File Offset: 0x00059F75
			public _UpdateIcon_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170037E6 RID: 14310
			// (get) Token: 0x0600AA5A RID: 43610 RVA: 0x002C1BD0 File Offset: 0x002BFDD0
			// (set) Token: 0x0600AA5B RID: 43611 RVA: 0x0005BD7E File Offset: 0x00059F7E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170037E7 RID: 14311
			// (get) Token: 0x0600AA5C RID: 43612 RVA: 0x002C1BF8 File Offset: 0x002BFDF8
			// (set) Token: 0x0600AA5D RID: 43613 RVA: 0x0005BD99 File Offset: 0x00059F99
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170037E8 RID: 14312
			// (get) Token: 0x0600AA5E RID: 43614 RVA: 0x002C1C28 File Offset: 0x002BFE28
			// (set) Token: 0x0600AA5F RID: 43615 RVA: 0x0005BDB8 File Offset: 0x00059FB8
			public unsafe GuestIconManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestIconManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestIconManager._UpdateIcon_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E04 RID: 28164
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006E05 RID: 28165
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006E06 RID: 28166
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006E07 RID: 28167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006E08 RID: 28168
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006E09 RID: 28169
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006E0A RID: 28170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006E0B RID: 28171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006E0C RID: 28172
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
