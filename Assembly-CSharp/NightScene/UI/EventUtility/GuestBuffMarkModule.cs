using System;
using DEYU.Singletons;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene.UI.EventUtility
{
	// Token: 0x020001D2 RID: 466
	public class GuestBuffMarkModule : MonoSingleton<GuestBuffMarkModule>
	{
		// Token: 0x06003A67 RID: 14951 RVA: 0x00165A34 File Offset: 0x00163C34
		// Note: this type is marked as 'beforefieldinit'.
		static GuestBuffMarkModule()
		{
			Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.EventUtility", "GuestBuffMarkModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr);
			GuestBuffMarkModule.NativeFieldInfoPtr_m_GuestBuffMarkSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "m_GuestBuffMarkSort");
			GuestBuffMarkModule.NativeFieldInfoPtr_m_BuffMarkContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "m_BuffMarkContainer");
			GuestBuffMarkModule.NativeFieldInfoPtr_m_BuffMarkUIParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "m_BuffMarkUIParent");
			GuestBuffMarkModule.NativeFieldInfoPtr_buffMarkSetAccordingToDeskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "buffMarkSetAccordingToDeskCode");
			GuestBuffMarkModule.NativeFieldInfoPtr_guestBuffMarkPropertiesDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "guestBuffMarkPropertiesDic");
			GuestBuffMarkModule.NativeFieldInfoPtr_guestBuffMarkSortingDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "guestBuffMarkSortingDic");
			GuestBuffMarkModule.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "m_Camera");
			GuestBuffMarkModule.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "m_Canvas");
			GuestBuffMarkModule.NativeFieldInfoPtr_m_Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "m_Comparer");
			GuestBuffMarkModule.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674171);
			GuestBuffMarkModule.NativeMethodInfoPtr_TryShowTargetDeskBuffMarkCanvasGroup_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674172);
			GuestBuffMarkModule.NativeMethodInfoPtr_GetUiWorldPosition_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674173);
			GuestBuffMarkModule.NativeMethodInfoPtr_TrySpawnTargetDeskNewBuffMark_Public_Boolean_Int32_GuestBuffMark_GameObject_Action_1_GameObject_Action_1_GameObject_byref_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674174);
			GuestBuffMarkModule.NativeMethodInfoPtr_ClearBuffMarkWhenTargetDeskGuestLeave_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674175);
			GuestBuffMarkModule.NativeMethodInfoPtr_RemoveTargetBuffMark_Public_Void_Int32_GuestBuffMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674176);
			GuestBuffMarkModule.NativeMethodInfoPtr_GetBuffMarkSortIndex_Private_Int32_GuestBuffMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674177);
			GuestBuffMarkModule.NativeMethodInfoPtr_RefreshTargetBuffMarkContainerSorting_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674178);
			GuestBuffMarkModule.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674179);
			GuestBuffMarkModule.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674180);
			GuestBuffMarkModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674181);
			GuestBuffMarkModule.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_0_Private_Int32_KeyValuePair_2_GuestBuffMark_ValueTuple_2_List_1_GameObject_Action_1_GameObject_KeyValuePair_2_GuestBuffMark_ValueTuple_2_List_1_GameObject_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, 100674182);
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00165C08 File Offset: 0x00163E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132873, RefRangeEnd = 132874, XrefRangeStart = 132821, XrefRangeEnd = 132873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x00165C3C File Offset: 0x00163E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132884, RefRangeEnd = 132885, XrefRangeStart = 132874, XrefRangeEnd = 132884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryShowTargetDeskBuffMarkCanvasGroup(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr_TryShowTargetDeskBuffMarkCanvasGroup_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x00165C7C File Offset: 0x00163E7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132886, RefRangeEnd = 132889, XrefRangeStart = 132885, XrefRangeEnd = 132886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetUiWorldPosition(Vector3 oldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr_GetUiWorldPosition_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00165CC8 File Offset: 0x00163EC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 132992, RefRangeEnd = 132996, XrefRangeStart = 132889, XrefRangeEnd = 132992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySpawnTargetDeskNewBuffMark(int deskCode, GuestBuffMarkModule.GuestBuffMark buffMarkType, GameObject buffMarkEffect, Action<GameObject> objectProcessingCallback, Action<GameObject> onMarkRemovedCallback, out GameObject effect, int index = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffMarkType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffMarkEffect);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectProcessingCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onMarkRemovedCallback);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr_TrySpawnTargetDeskNewBuffMark_Public_Boolean_Int32_GuestBuffMark_GameObject_Action_1_GameObject_Action_1_GameObject_byref_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			effect = ((intPtr4 == 0) ? null : new GameObject(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x00165D8C File Offset: 0x00163F8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133023, RefRangeEnd = 133024, XrefRangeStart = 132996, XrefRangeEnd = 133023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBuffMarkWhenTargetDeskGuestLeave(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr_ClearBuffMarkWhenTargetDeskGuestLeave_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x00165DCC File Offset: 0x00163FCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 133051, RefRangeEnd = 133054, XrefRangeStart = 133024, XrefRangeEnd = 133051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTargetBuffMark(int deskCode, GuestBuffMarkModule.GuestBuffMark guestBuffMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestBuffMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr_RemoveTargetBuffMark_Public_Void_Int32_GuestBuffMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00165E18 File Offset: 0x00164018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133054, XrefRangeEnd = 133057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBuffMarkSortIndex(GuestBuffMarkModule.GuestBuffMark mark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr_GetBuffMarkSortIndex_Private_Int32_GuestBuffMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x00165E64 File Offset: 0x00164064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133169, RefRangeEnd = 133171, XrefRangeStart = 133057, XrefRangeEnd = 133169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTargetBuffMarkContainerSorting(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr_RefreshTargetBuffMarkContainerSorting_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x00165EA4 File Offset: 0x001640A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133171, XrefRangeEnd = 133181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestBuffMarkModule.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x00165EE0 File Offset: 0x001640E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestBuffMarkModule.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x00165F1C File Offset: 0x0016411C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133181, XrefRangeEnd = 133213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestBuffMarkModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x00165F58 File Offset: 0x00164158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133213, XrefRangeEnd = 133221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RefreshTargetBuffMarkContainerSorting_b__18_0(KeyValuePair<GuestBuffMarkModule.GuestBuffMark, ValueTuple<List<GameObject>, Action<GameObject>>> a, KeyValuePair<GuestBuffMarkModule.GuestBuffMark, ValueTuple<List<GameObject>, Action<GameObject>>> b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_0_Private_Int32_KeyValuePair_2_GuestBuffMark_ValueTuple_2_List_1_GameObject_Action_1_GameObject_KeyValuePair_2_GuestBuffMark_ValueTuple_2_List_1_GameObject_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00020B6E File Offset: 0x0001ED6E
		public GuestBuffMarkModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x00165FC4 File Offset: 0x001641C4
		// (set) Token: 0x06003A76 RID: 14966 RVA: 0x00020B77 File Offset: 0x0001ED77
		public unsafe List<GuestBuffMarkModule.GuestBuffMarkProperty> m_GuestBuffMarkSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_GuestBuffMarkSort);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GuestBuffMarkModule.GuestBuffMarkProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_GuestBuffMarkSort), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x00165FF4 File Offset: 0x001641F4
		// (set) Token: 0x06003A78 RID: 14968 RVA: 0x00020B96 File Offset: 0x0001ED96
		public unsafe GameObject m_BuffMarkContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_BuffMarkContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_BuffMarkContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06003A79 RID: 14969 RVA: 0x00166024 File Offset: 0x00164224
		// (set) Token: 0x06003A7A RID: 14970 RVA: 0x00020BB5 File Offset: 0x0001EDB5
		public unsafe RectTransform m_BuffMarkUIParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_BuffMarkUIParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_BuffMarkUIParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06003A7B RID: 14971 RVA: 0x00166054 File Offset: 0x00164254
		// (set) Token: 0x06003A7C RID: 14972 RVA: 0x00020BD4 File Offset: 0x0001EDD4
		public unsafe Dictionary<int, ValueTuple<UIElementCluster, Dictionary<GuestBuffMarkModule.GuestBuffMark, ValueTuple<List<GameObject>, Action<GameObject>>>>> buffMarkSetAccordingToDeskCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_buffMarkSetAccordingToDeskCode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<UIElementCluster, Dictionary<GuestBuffMarkModule.GuestBuffMark, ValueTuple<List<GameObject>, Action<GameObject>>>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_buffMarkSetAccordingToDeskCode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x00166084 File Offset: 0x00164284
		// (set) Token: 0x06003A7E RID: 14974 RVA: 0x00020BF3 File Offset: 0x0001EDF3
		public unsafe Dictionary<GuestBuffMarkModule.GuestBuffMark, ValueTuple<int, GuestBuffMarkModule.GuestBuffMarkProperty>> guestBuffMarkPropertiesDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_guestBuffMarkPropertiesDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GuestBuffMarkModule.GuestBuffMark, ValueTuple<int, GuestBuffMarkModule.GuestBuffMarkProperty>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_guestBuffMarkPropertiesDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x001660B4 File Offset: 0x001642B4
		// (set) Token: 0x06003A80 RID: 14976 RVA: 0x00020C12 File Offset: 0x0001EE12
		public unsafe Dictionary<GuestBuffMarkModule.GuestBuffMark, HashSet<GuestBuffMarkModule.GuestBuffMark>> guestBuffMarkSortingDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_guestBuffMarkSortingDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GuestBuffMarkModule.GuestBuffMark, HashSet<GuestBuffMarkModule.GuestBuffMark>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_guestBuffMarkSortingDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x001660E4 File Offset: 0x001642E4
		// (set) Token: 0x06003A82 RID: 14978 RVA: 0x00020C31 File Offset: 0x0001EE31
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x00166114 File Offset: 0x00164314
		// (set) Token: 0x06003A84 RID: 14980 RVA: 0x00020C50 File Offset: 0x0001EE50
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x00166144 File Offset: 0x00164344
		// (set) Token: 0x06003A86 RID: 14982 RVA: 0x00020C6F File Offset: 0x0001EE6F
		public unsafe Comparer<int> m_Comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_Comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.NativeFieldInfoPtr_m_Comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002745 RID: 10053
		private static readonly IntPtr NativeFieldInfoPtr_m_GuestBuffMarkSort;

		// Token: 0x04002746 RID: 10054
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffMarkContainer;

		// Token: 0x04002747 RID: 10055
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffMarkUIParent;

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeFieldInfoPtr_buffMarkSetAccordingToDeskCode;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeFieldInfoPtr_guestBuffMarkPropertiesDic;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeFieldInfoPtr_guestBuffMarkSortingDic;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeFieldInfoPtr_m_Comparer;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_TryShowTargetDeskBuffMarkCanvasGroup_Public_Void_Int32_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_GetUiWorldPosition_Public_Vector3_Vector3_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_TrySpawnTargetDeskNewBuffMark_Public_Boolean_Int32_GuestBuffMark_GameObject_Action_1_GameObject_Action_1_GameObject_byref_GameObject_Int32_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr_ClearBuffMarkWhenTargetDeskGuestLeave_Public_Void_Int32_0;

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetBuffMark_Public_Void_Int32_GuestBuffMark_0;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffMarkSortIndex_Private_Int32_GuestBuffMark_0;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTargetBuffMarkContainerSorting_Private_Void_Int32_0;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_0_Private_Int32_KeyValuePair_2_GuestBuffMark_ValueTuple_2_List_1_GameObject_Action_1_GameObject_KeyValuePair_2_GuestBuffMark_ValueTuple_2_List_1_GameObject_Action_1_GameObject_0;

		// Token: 0x02000958 RID: 2392
		public enum DisplayType
		{
			// Token: 0x040078A8 RID: 30888
			Floating,
			// Token: 0x040078A9 RID: 30889
			Static
		}

		// Token: 0x02000959 RID: 2393
		public enum GuestBuffMark
		{
			// Token: 0x040078AB RID: 30891
			BuffMark_Rin,
			// Token: 0x040078AC RID: 30892
			BuffMark_Seija,
			// Token: 0x040078AD RID: 30893
			BuffMark_JienYuuEye,
			// Token: 0x040078AE RID: 30894
			BuffMark_SatoriEye
		}

		// Token: 0x0200095A RID: 2394
		[Serializable]
		public sealed class GuestBuffMarkProperty : ValueType
		{
			// Token: 0x0600BABD RID: 47805 RVA: 0x002F10B8 File Offset: 0x002EF2B8
			// Note: this type is marked as 'beforefieldinit'.
			static GuestBuffMarkProperty()
			{
				Il2CppClassPointerStore<GuestBuffMarkModule.GuestBuffMarkProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "GuestBuffMarkProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestBuffMarkModule.GuestBuffMarkProperty>.NativeClassPtr);
				GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_buffMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.GuestBuffMarkProperty>.NativeClassPtr, "buffMark");
				GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_displayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.GuestBuffMarkProperty>.NativeClassPtr, "displayType");
				GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_overridedByOtherMarkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.GuestBuffMarkProperty>.NativeClassPtr, "overridedByOtherMarkList");
			}

			// Token: 0x0600BABE RID: 47806 RVA: 0x00064C0C File Offset: 0x00062E0C
			public GuestBuffMarkProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BABF RID: 47807 RVA: 0x00064C15 File Offset: 0x00062E15
			public GuestBuffMarkProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestBuffMarkModule.GuestBuffMarkProperty>.NativeClassPtr))
			{
			}

			// Token: 0x17003D20 RID: 15648
			// (get) Token: 0x0600BAC0 RID: 47808 RVA: 0x002F1120 File Offset: 0x002EF320
			// (set) Token: 0x0600BAC1 RID: 47809 RVA: 0x00064C27 File Offset: 0x00062E27
			public unsafe GuestBuffMarkModule.GuestBuffMark buffMark
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_buffMark);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_buffMark)) = value;
				}
			}

			// Token: 0x17003D21 RID: 15649
			// (get) Token: 0x0600BAC2 RID: 47810 RVA: 0x002F1148 File Offset: 0x002EF348
			// (set) Token: 0x0600BAC3 RID: 47811 RVA: 0x00064C42 File Offset: 0x00062E42
			public unsafe GuestBuffMarkModule.DisplayType displayType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_displayType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_displayType)) = value;
				}
			}

			// Token: 0x17003D22 RID: 15650
			// (get) Token: 0x0600BAC4 RID: 47812 RVA: 0x002F1170 File Offset: 0x002EF370
			// (set) Token: 0x0600BAC5 RID: 47813 RVA: 0x00064C5D File Offset: 0x00062E5D
			public unsafe Il2CppStructArray<GuestBuffMarkModule.GuestBuffMark> overridedByOtherMarkList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_overridedByOtherMarkList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GuestBuffMarkModule.GuestBuffMark>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.GuestBuffMarkProperty.NativeFieldInfoPtr_overridedByOtherMarkList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078AF RID: 30895
			private static readonly IntPtr NativeFieldInfoPtr_buffMark;

			// Token: 0x040078B0 RID: 30896
			private static readonly IntPtr NativeFieldInfoPtr_displayType;

			// Token: 0x040078B1 RID: 30897
			private static readonly IntPtr NativeFieldInfoPtr_overridedByOtherMarkList;
		}

		// Token: 0x0200095B RID: 2395
		[ObfuscatedName("NightScene.UI.EventUtility.GuestBuffMarkModule+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BAC6 RID: 47814 RVA: 0x002F11A0 File Offset: 0x002EF3A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass11_0>.NativeClassPtr);
				GuestBuffMarkModule.__c__DisplayClass11_0.NativeFieldInfoPtr_buffMarkPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass11_0>.NativeClassPtr, "buffMarkPair");
				GuestBuffMarkModule.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass11_0>.NativeClassPtr, 100674183);
				GuestBuffMarkModule.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Boolean_GuestBuffMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass11_0>.NativeClassPtr, 100674184);
			}

			// Token: 0x0600BAC7 RID: 47815 RVA: 0x002F1208 File Offset: 0x002EF408
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAC8 RID: 47816 RVA: 0x002F1244 File Offset: 0x002EF444
			[CallerCount(0)]
			public unsafe bool _Initialize_b__0(GuestBuffMarkModule.GuestBuffMark x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Boolean_GuestBuffMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BAC9 RID: 47817 RVA: 0x00064C7C File Offset: 0x00062E7C
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D23 RID: 15651
			// (get) Token: 0x0600BACA RID: 47818 RVA: 0x002F1290 File Offset: 0x002EF490
			// (set) Token: 0x0600BACB RID: 47819 RVA: 0x00064C85 File Offset: 0x00062E85
			public GuestBuffMarkModule.GuestBuffMarkProperty buffMarkPair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.__c__DisplayClass11_0.NativeFieldInfoPtr_buffMarkPair);
					return new GuestBuffMarkModule.GuestBuffMarkProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GuestBuffMarkModule.GuestBuffMarkProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.__c__DisplayClass11_0.NativeFieldInfoPtr_buffMarkPair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GuestBuffMarkModule.GuestBuffMarkProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040078B2 RID: 30898
			private static readonly IntPtr NativeFieldInfoPtr_buffMarkPair;

			// Token: 0x040078B3 RID: 30899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078B4 RID: 30900
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Boolean_GuestBuffMark_0;
		}

		// Token: 0x0200095C RID: 2396
		[ObfuscatedName("NightScene.UI.EventUtility.GuestBuffMarkModule+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BACC RID: 47820 RVA: 0x002F12C0 File Offset: 0x002EF4C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass15_0>.NativeClassPtr);
				GuestBuffMarkModule.__c__DisplayClass15_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass15_0>.NativeClassPtr, "x");
				GuestBuffMarkModule.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass15_0>.NativeClassPtr, 100674185);
				GuestBuffMarkModule.__c__DisplayClass15_0.NativeMethodInfoPtr__ClearBuffMarkWhenTargetDeskGuestLeave_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass15_0>.NativeClassPtr, 100674186);
			}

			// Token: 0x0600BACD RID: 47821 RVA: 0x002F1328 File Offset: 0x002EF528
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BACE RID: 47822 RVA: 0x002F1364 File Offset: 0x002EF564
			[CallerCount(0)]
			public unsafe void _ClearBuffMarkWhenTargetDeskGuestLeave_b__1(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c__DisplayClass15_0.NativeMethodInfoPtr__ClearBuffMarkWhenTargetDeskGuestLeave_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BACF RID: 47823 RVA: 0x00064CB3 File Offset: 0x00062EB3
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D24 RID: 15652
			// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x002F13A8 File Offset: 0x002EF5A8
			// (set) Token: 0x0600BAD1 RID: 47825 RVA: 0x00064CBC File Offset: 0x00062EBC
			public ValueTuple<List<GameObject>, Action<GameObject>> x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.__c__DisplayClass15_0.NativeFieldInfoPtr_x);
					return new ValueTuple<List<GameObject>, Action<GameObject>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<List<GameObject>, Action<GameObject>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.__c__DisplayClass15_0.NativeFieldInfoPtr_x), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<List<GameObject>, Action<GameObject>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040078B5 RID: 30901
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040078B6 RID: 30902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078B7 RID: 30903
			private static readonly IntPtr NativeMethodInfoPtr__ClearBuffMarkWhenTargetDeskGuestLeave_b__1_Internal_Void_GameObject_0;
		}

		// Token: 0x0200095D RID: 2397
		[ObfuscatedName("NightScene.UI.EventUtility.GuestBuffMarkModule+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BAD2 RID: 47826 RVA: 0x002F13D8 File Offset: 0x002EF5D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr);
				GuestBuffMarkModule.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, "<>9");
				GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, "<>9__15_0");
				GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, "<>9__18_1");
				GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, "<>9__18_2");
				GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, "<>9__18_3");
				GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, "<>9__18_4");
				GuestBuffMarkModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, 100674188);
				GuestBuffMarkModule.__c.NativeMethodInfoPtr__ClearBuffMarkWhenTargetDeskGuestLeave_b__15_0_Internal_Void_ValueTuple_2_List_1_GameObject_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, 100674189);
				GuestBuffMarkModule.__c.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_1_Internal_Transform_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, 100674190);
				GuestBuffMarkModule.__c.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_2_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, 100674191);
				GuestBuffMarkModule.__c.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_3_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, 100674192);
				GuestBuffMarkModule.__c.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_4_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr, 100674193);
			}

			// Token: 0x0600BAD3 RID: 47827 RVA: 0x002F14F4 File Offset: 0x002EF6F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestBuffMarkModule.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAD4 RID: 47828 RVA: 0x002F1530 File Offset: 0x002EF730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132796, XrefRangeEnd = 132811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ClearBuffMarkWhenTargetDeskGuestLeave_b__15_0(ValueTuple<List<GameObject>, Action<GameObject>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c.NativeMethodInfoPtr__ClearBuffMarkWhenTargetDeskGuestLeave_b__15_0_Internal_Void_ValueTuple_2_List_1_GameObject_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAD5 RID: 47829 RVA: 0x002F1578 File Offset: 0x002EF778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132811, XrefRangeEnd = 132813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transform _RefreshTargetBuffMarkContainerSorting_b__18_1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_1_Internal_Transform_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}

			// Token: 0x0600BAD6 RID: 47830 RVA: 0x002F15C8 File Offset: 0x002EF7C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132813, XrefRangeEnd = 132816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshTargetBuffMarkContainerSorting_b__18_2(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_2_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAD7 RID: 47831 RVA: 0x002F160C File Offset: 0x002EF80C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132816, XrefRangeEnd = 132819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshTargetBuffMarkContainerSorting_b__18_3(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_3_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAD8 RID: 47832 RVA: 0x002F1650 File Offset: 0x002EF850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132819, XrefRangeEnd = 132821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshTargetBuffMarkContainerSorting_b__18_4(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c.NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_4_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAD9 RID: 47833 RVA: 0x00064CEA File Offset: 0x00062EEA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D25 RID: 15653
			// (get) Token: 0x0600BADA RID: 47834 RVA: 0x002F1694 File Offset: 0x002EF894
			// (set) Token: 0x0600BADB RID: 47835 RVA: 0x00064CF3 File Offset: 0x00062EF3
			public unsafe static GuestBuffMarkModule.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestBuffMarkModule.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D26 RID: 15654
			// (get) Token: 0x0600BADC RID: 47836 RVA: 0x002F16BC File Offset: 0x002EF8BC
			// (set) Token: 0x0600BADD RID: 47837 RVA: 0x00064D05 File Offset: 0x00062F05
			public unsafe static Action<ValueTuple<List<GameObject>, Action<GameObject>>> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValueTuple<List<GameObject>, Action<GameObject>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D27 RID: 15655
			// (get) Token: 0x0600BADE RID: 47838 RVA: 0x002F16E4 File Offset: 0x002EF8E4
			// (set) Token: 0x0600BADF RID: 47839 RVA: 0x00064D17 File Offset: 0x00062F17
			public unsafe static Func<GameObject, Transform> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D28 RID: 15656
			// (get) Token: 0x0600BAE0 RID: 47840 RVA: 0x002F170C File Offset: 0x002EF90C
			// (set) Token: 0x0600BAE1 RID: 47841 RVA: 0x00064D29 File Offset: 0x00062F29
			public unsafe static Action<Transform> __9__18_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D29 RID: 15657
			// (get) Token: 0x0600BAE2 RID: 47842 RVA: 0x002F1734 File Offset: 0x002EF934
			// (set) Token: 0x0600BAE3 RID: 47843 RVA: 0x00064D3B File Offset: 0x00062F3B
			public unsafe static Action<Transform> __9__18_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D2A RID: 15658
			// (get) Token: 0x0600BAE4 RID: 47844 RVA: 0x002F175C File Offset: 0x002EF95C
			// (set) Token: 0x0600BAE5 RID: 47845 RVA: 0x00064D4D File Offset: 0x00062F4D
			public unsafe static Action<Transform> __9__18_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuestBuffMarkModule.__c.NativeFieldInfoPtr___9__18_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078B8 RID: 30904
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040078B9 RID: 30905
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040078BA RID: 30906
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x040078BB RID: 30907
			private static readonly IntPtr NativeFieldInfoPtr___9__18_2;

			// Token: 0x040078BC RID: 30908
			private static readonly IntPtr NativeFieldInfoPtr___9__18_3;

			// Token: 0x040078BD RID: 30909
			private static readonly IntPtr NativeFieldInfoPtr___9__18_4;

			// Token: 0x040078BE RID: 30910
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078BF RID: 30911
			private static readonly IntPtr NativeMethodInfoPtr__ClearBuffMarkWhenTargetDeskGuestLeave_b__15_0_Internal_Void_ValueTuple_2_List_1_GameObject_Action_1_GameObject_0;

			// Token: 0x040078C0 RID: 30912
			private static readonly IntPtr NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_1_Internal_Transform_GameObject_0;

			// Token: 0x040078C1 RID: 30913
			private static readonly IntPtr NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_2_Internal_Void_Transform_0;

			// Token: 0x040078C2 RID: 30914
			private static readonly IntPtr NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_3_Internal_Void_Transform_0;

			// Token: 0x040078C3 RID: 30915
			private static readonly IntPtr NativeMethodInfoPtr__RefreshTargetBuffMarkContainerSorting_b__18_4_Internal_Void_Transform_0;
		}

		// Token: 0x0200095E RID: 2398
		[ObfuscatedName("NightScene.UI.EventUtility.GuestBuffMarkModule+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BAE6 RID: 47846 RVA: 0x002F1784 File Offset: 0x002EF984
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuestBuffMarkModule>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass16_0>.NativeClassPtr);
				GuestBuffMarkModule.__c__DisplayClass16_0.NativeFieldInfoPtr_effectPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass16_0>.NativeClassPtr, "effectPair");
				GuestBuffMarkModule.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass16_0>.NativeClassPtr, 100674194);
				GuestBuffMarkModule.__c__DisplayClass16_0.NativeMethodInfoPtr__RemoveTargetBuffMark_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass16_0>.NativeClassPtr, 100674195);
			}

			// Token: 0x0600BAE7 RID: 47847 RVA: 0x002F17EC File Offset: 0x002EF9EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestBuffMarkModule.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAE8 RID: 47848 RVA: 0x002F1828 File Offset: 0x002EFA28
			[CallerCount(0)]
			public unsafe void _RemoveTargetBuffMark_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBuffMarkModule.__c__DisplayClass16_0.NativeMethodInfoPtr__RemoveTargetBuffMark_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAE9 RID: 47849 RVA: 0x00064D5F File Offset: 0x00062F5F
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D2B RID: 15659
			// (get) Token: 0x0600BAEA RID: 47850 RVA: 0x002F186C File Offset: 0x002EFA6C
			// (set) Token: 0x0600BAEB RID: 47851 RVA: 0x00064D68 File Offset: 0x00062F68
			public ValueTuple<List<GameObject>, Action<GameObject>> effectPair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.__c__DisplayClass16_0.NativeFieldInfoPtr_effectPair);
					return new ValueTuple<List<GameObject>, Action<GameObject>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<List<GameObject>, Action<GameObject>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBuffMarkModule.__c__DisplayClass16_0.NativeFieldInfoPtr_effectPair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<List<GameObject>, Action<GameObject>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040078C4 RID: 30916
			private static readonly IntPtr NativeFieldInfoPtr_effectPair;

			// Token: 0x040078C5 RID: 30917
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078C6 RID: 30918
			private static readonly IntPtr NativeMethodInfoPtr__RemoveTargetBuffMark_b__0_Internal_Void_GameObject_0;
		}
	}
}
