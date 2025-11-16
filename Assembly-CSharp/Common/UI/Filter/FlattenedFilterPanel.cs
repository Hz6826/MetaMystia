using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;

namespace Common.UI.Filter
{
	// Token: 0x020003BA RID: 954
	public class FlattenedFilterPanel : UIPanelParamOpen<FilterParam>
	{
		// Token: 0x06007186 RID: 29062 RVA: 0x002190D4 File Offset: 0x002172D4
		// Note: this type is marked as 'beforefieldinit'.
		static FlattenedFilterPanel()
		{
			Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "FlattenedFilterPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr);
			FlattenedFilterPanel.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_Button");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_SingleChoiceModule");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_MultipleChoiceModule");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModuleField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_SingleChoiceModuleField");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModuleField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_MultipleChoiceModuleField");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_FilterUIControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_FilterUIControllers");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_UsedMultipleChoiceModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_UsedMultipleChoiceModule");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_UsedSingleChoiceModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_UsedSingleChoiceModule");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModulePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_MultipleChoiceModulePool");
			FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModulePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "m_SingleChoiceModulePool");
			FlattenedFilterPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686444);
			FlattenedFilterPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_FilterParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686445);
			FlattenedFilterPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686446);
			FlattenedFilterPanel.NativeMethodInfoPtr_CreateFilterUIController_Private_IFilterUIController_IFilterConfigFactory_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686447);
			FlattenedFilterPanel.NativeMethodInfoPtr_GetInstanceAndRecordUsage_Private_Static_UIElementCluster_IObjectPool_1_UIElementCluster_Stack_1_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686448);
			FlattenedFilterPanel.NativeMethodInfoPtr_ReleaseInstance_Private_Static_Void_IObjectPool_1_UIElementCluster_Stack_1_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686449);
			FlattenedFilterPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686450);
			FlattenedFilterPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686451);
			FlattenedFilterPanel.NativeMethodInfoPtr_Method_Internal_Static_ObjectPool_1_UIElementCluster_UIElementCluster_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, 100686452);
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x00219280 File Offset: 0x00217480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282691, XrefRangeEnd = 282700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlattenedFilterPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x002192BC File Offset: 0x002174BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282700, XrefRangeEnd = 282784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(FilterParam openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlattenedFilterPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_FilterParam_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x00219310 File Offset: 0x00217510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282784, XrefRangeEnd = 282799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlattenedFilterPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x0021934C File Offset: 0x0021754C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282813, RefRangeEnd = 282814, XrefRangeStart = 282799, XrefRangeEnd = 282813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlattenedFilterPanel.IFilterUIController CreateFilterUIController(IFilterConfigFactory factory, IFilterConfig filterConfig)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.NativeMethodInfoPtr_CreateFilterUIController_Private_IFilterUIController_IFilterConfigFactory_IFilterConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FlattenedFilterPanel.IFilterUIController>(intPtr3) : null;
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x002193B0 File Offset: 0x002175B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282820, RefRangeEnd = 282822, XrefRangeStart = 282814, XrefRangeEnd = 282820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UIElementCluster GetInstanceAndRecordUsage(IObjectPool<UIElementCluster> pool, Stack<UIElementCluster> occupiedTracker)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupiedTracker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.NativeMethodInfoPtr_GetInstanceAndRecordUsage_Private_Static_UIElementCluster_IObjectPool_1_UIElementCluster_Stack_1_UIElementCluster_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x00219408 File Offset: 0x00217608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282830, RefRangeEnd = 282832, XrefRangeStart = 282822, XrefRangeEnd = 282830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseInstance(IObjectPool<UIElementCluster> pool, Stack<UIElementCluster> occupiedTracker)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupiedTracker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.NativeMethodInfoPtr_ReleaseInstance_Private_Static_Void_IObjectPool_1_UIElementCluster_Stack_1_UIElementCluster_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x00219450 File Offset: 0x00217650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282832, XrefRangeEnd = 282848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlattenedFilterPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x0021948C File Offset: 0x0021768C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282848, XrefRangeEnd = 282871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlattenedFilterPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x002194C8 File Offset: 0x002176C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282930, RefRangeEnd = 282932, XrefRangeStart = 282871, XrefRangeEnd = 282930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectPool<UIElementCluster> Method_Internal_Static_ObjectPool_1_UIElementCluster_UIElementCluster_Transform_0(UIElementCluster module, Transform field)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.NativeMethodInfoPtr_Method_Internal_Static_ObjectPool_1_UIElementCluster_UIElementCluster_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectPool<UIElementCluster>>(intPtr3) : null;
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x0003D7F4 File Offset: 0x0003B9F4
		public FlattenedFilterPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x06007191 RID: 29073 RVA: 0x00219520 File Offset: 0x00217720
		// (set) Token: 0x06007192 RID: 29074 RVA: 0x0003D7FD File Offset: 0x0003B9FD
		public unsafe UIElementCluster m_Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x06007193 RID: 29075 RVA: 0x00219550 File Offset: 0x00217750
		// (set) Token: 0x06007194 RID: 29076 RVA: 0x0003D81C File Offset: 0x0003BA1C
		public unsafe UIElementCluster m_SingleChoiceModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x06007195 RID: 29077 RVA: 0x00219580 File Offset: 0x00217780
		// (set) Token: 0x06007196 RID: 29078 RVA: 0x0003D83B File Offset: 0x0003BA3B
		public unsafe UIElementCluster m_MultipleChoiceModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x06007197 RID: 29079 RVA: 0x002195B0 File Offset: 0x002177B0
		// (set) Token: 0x06007198 RID: 29080 RVA: 0x0003D85A File Offset: 0x0003BA5A
		public unsafe RectTransform m_SingleChoiceModuleField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModuleField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModuleField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x002195E0 File Offset: 0x002177E0
		// (set) Token: 0x0600719A RID: 29082 RVA: 0x0003D879 File Offset: 0x0003BA79
		public unsafe RectTransform m_MultipleChoiceModuleField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModuleField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModuleField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x0600719B RID: 29083 RVA: 0x00219610 File Offset: 0x00217810
		// (set) Token: 0x0600719C RID: 29084 RVA: 0x0003D898 File Offset: 0x0003BA98
		public unsafe Queue<FlattenedFilterPanel.IFilterUIController> m_FilterUIControllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_FilterUIControllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<FlattenedFilterPanel.IFilterUIController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_FilterUIControllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x0600719D RID: 29085 RVA: 0x00219640 File Offset: 0x00217840
		// (set) Token: 0x0600719E RID: 29086 RVA: 0x0003D8B7 File Offset: 0x0003BAB7
		public unsafe Stack<UIElementCluster> m_UsedMultipleChoiceModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_UsedMultipleChoiceModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_UsedMultipleChoiceModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x0600719F RID: 29087 RVA: 0x00219670 File Offset: 0x00217870
		// (set) Token: 0x060071A0 RID: 29088 RVA: 0x0003D8D6 File Offset: 0x0003BAD6
		public unsafe Stack<UIElementCluster> m_UsedSingleChoiceModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_UsedSingleChoiceModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_UsedSingleChoiceModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x060071A1 RID: 29089 RVA: 0x002196A0 File Offset: 0x002178A0
		// (set) Token: 0x060071A2 RID: 29090 RVA: 0x0003D8F5 File Offset: 0x0003BAF5
		public unsafe ObjectPool<UIElementCluster> m_MultipleChoiceModulePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModulePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_MultipleChoiceModulePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x060071A3 RID: 29091 RVA: 0x002196D0 File Offset: 0x002178D0
		// (set) Token: 0x060071A4 RID: 29092 RVA: 0x0003D914 File Offset: 0x0003BB14
		public unsafe ObjectPool<UIElementCluster> m_SingleChoiceModulePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModulePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.NativeFieldInfoPtr_m_SingleChoiceModulePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B35 RID: 19253
		private static readonly IntPtr NativeFieldInfoPtr_m_Button;

		// Token: 0x04004B36 RID: 19254
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleChoiceModule;

		// Token: 0x04004B37 RID: 19255
		private static readonly IntPtr NativeFieldInfoPtr_m_MultipleChoiceModule;

		// Token: 0x04004B38 RID: 19256
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleChoiceModuleField;

		// Token: 0x04004B39 RID: 19257
		private static readonly IntPtr NativeFieldInfoPtr_m_MultipleChoiceModuleField;

		// Token: 0x04004B3A RID: 19258
		private static readonly IntPtr NativeFieldInfoPtr_m_FilterUIControllers;

		// Token: 0x04004B3B RID: 19259
		private static readonly IntPtr NativeFieldInfoPtr_m_UsedMultipleChoiceModule;

		// Token: 0x04004B3C RID: 19260
		private static readonly IntPtr NativeFieldInfoPtr_m_UsedSingleChoiceModule;

		// Token: 0x04004B3D RID: 19261
		private static readonly IntPtr NativeFieldInfoPtr_m_MultipleChoiceModulePool;

		// Token: 0x04004B3E RID: 19262
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleChoiceModulePool;

		// Token: 0x04004B3F RID: 19263
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004B40 RID: 19264
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_FilterParam_0;

		// Token: 0x04004B41 RID: 19265
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004B42 RID: 19266
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterUIController_Private_IFilterUIController_IFilterConfigFactory_IFilterConfig_0;

		// Token: 0x04004B43 RID: 19267
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceAndRecordUsage_Private_Static_UIElementCluster_IObjectPool_1_UIElementCluster_Stack_1_UIElementCluster_0;

		// Token: 0x04004B44 RID: 19268
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInstance_Private_Static_Void_IObjectPool_1_UIElementCluster_Stack_1_UIElementCluster_0;

		// Token: 0x04004B45 RID: 19269
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004B46 RID: 19270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004B47 RID: 19271
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_ObjectPool_1_UIElementCluster_UIElementCluster_Transform_0;

		// Token: 0x02000F07 RID: 3847
		public class IFilterUIController : Il2CppObjectBase
		{
			// Token: 0x06010E10 RID: 69136 RVA: 0x003E6B08 File Offset: 0x003E4D08
			// Note: this type is marked as 'beforefieldinit'.
			static IFilterUIController()
			{
				Il2CppClassPointerStore<FlattenedFilterPanel.IFilterUIController>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "IFilterUIController");
				FlattenedFilterPanel.IFilterUIController.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.IFilterUIController>.NativeClassPtr, 100686453);
				FlattenedFilterPanel.IFilterUIController.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.IFilterUIController>.NativeClassPtr, 100686454);
				FlattenedFilterPanel.IFilterUIController.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.IFilterUIController>.NativeClassPtr, 100686455);
				FlattenedFilterPanel.IFilterUIController.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.IFilterUIController>.NativeClassPtr, 100686456);
			}

			// Token: 0x170057E0 RID: 22496
			// (get) Token: 0x06010E11 RID: 69137 RVA: 0x003E6B7C File Offset: 0x003E4D7C
			public unsafe virtual uint SelectionPriorityWeight
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlattenedFilterPanel.IFilterUIController.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010E12 RID: 69138 RVA: 0x003E6BC4 File Offset: 0x003E4DC4
			[CallerCount(0)]
			public unsafe virtual void Init()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlattenedFilterPanel.IFilterUIController.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E13 RID: 69139 RVA: 0x003E6C00 File Offset: 0x003E4E00
			[CallerCount(0)]
			public unsafe virtual void Select()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlattenedFilterPanel.IFilterUIController.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E14 RID: 69140 RVA: 0x003E6C3C File Offset: 0x003E4E3C
			[CallerCount(0)]
			public unsafe virtual IFilterConfig Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlattenedFilterPanel.IFilterUIController.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_IFilterConfig_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilterConfig>(intPtr3) : null;
			}

			// Token: 0x06010E15 RID: 69141 RVA: 0x0009303F File Offset: 0x0009123F
			public IFilterUIController(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AAC8 RID: 43720
			private static readonly IntPtr NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Abstract_Virtual_New_get_UInt32_0;

			// Token: 0x0400AAC9 RID: 43721
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0;

			// Token: 0x0400AACA RID: 43722
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_Void_0;

			// Token: 0x0400AACB RID: 43723
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_IFilterConfig_0;
		}

		// Token: 0x02000F08 RID: 3848
		public class MultipleChoiceFilterUIController : Il2CppSystem.Object
		{
			// Token: 0x06010E16 RID: 69142 RVA: 0x003E6C88 File Offset: 0x003E4E88
			// Note: this type is marked as 'beforefieldinit'.
			static MultipleChoiceFilterUIController()
			{
				Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "MultipleChoiceFilterUIController");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr);
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_FilterConfigFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, "m_FilterConfigFactory");
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_LogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, "m_LogicalGroup");
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_SelectedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, "m_SelectedList");
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_SelectionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, "m_SelectionList");
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, "<SelectionPriorityWeight>k__BackingField");
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_UIElementCluster_IFilterConfig_IFilterConfigFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, 100686457);
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, 100686458);
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, 100686459);
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, 100686460);
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, 100686461);
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr___ctor_b__4_0_Private_Void_Object_UIElementCluster_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, 100686462);
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr___ctor_b__4_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, 100686463);
				FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr___ctor_b__4_1_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, 100686464);
			}

			// Token: 0x06010E17 RID: 69143 RVA: 0x003E6DB8 File Offset: 0x003E4FB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282430, RefRangeEnd = 282431, XrefRangeStart = 282342, XrefRangeEnd = 282430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MultipleChoiceFilterUIController(UIElementCluster buttonPrefab, UIElementCluster moduleInstance, IFilterConfig filterConfig, IFilterConfigFactory filterConfigFactory) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttonPrefab);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moduleInstance);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterConfig);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterConfigFactory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_UIElementCluster_IFilterConfig_IFilterConfigFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170057E6 RID: 22502
			// (get) Token: 0x06010E18 RID: 69144 RVA: 0x003E6E3C File Offset: 0x003E503C
			public unsafe virtual uint SelectionPriorityWeight
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 53318, RefRangeEnd = 53319, XrefRangeStart = 53318, XrefRangeEnd = 53319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010E19 RID: 69145 RVA: 0x003E6E78 File Offset: 0x003E5078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282431, XrefRangeEnd = 282435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Select()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E1A RID: 69146 RVA: 0x003E6EAC File Offset: 0x003E50AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282435, XrefRangeEnd = 282473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IFilterConfig Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_IFilterConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilterConfig>(intPtr3) : null;
			}

			// Token: 0x06010E1B RID: 69147 RVA: 0x003E6EEC File Offset: 0x003E50EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282473, XrefRangeEnd = 282477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Init()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E1C RID: 69148 RVA: 0x003E6F20 File Offset: 0x003E5120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282477, XrefRangeEnd = 282516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__4_0(Il2CppSystem.Object obj, UIElementCluster ui, UIButtonToggle toggle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr___ctor_b__4_0_Private_Void_Object_UIElementCluster_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E1D RID: 69149 RVA: 0x003E6F88 File Offset: 0x003E5188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282516, XrefRangeEnd = 282522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__4_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr___ctor_b__4_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E1E RID: 69150 RVA: 0x003E6FBC File Offset: 0x003E51BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282522, XrefRangeEnd = 282529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__4_1(int columnIndex, MoveDirection dir)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref columnIndex;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeMethodInfoPtr___ctor_b__4_1_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E1F RID: 69151 RVA: 0x00093048 File Offset: 0x00091248
			public MultipleChoiceFilterUIController(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057E1 RID: 22497
			// (get) Token: 0x06010E20 RID: 69152 RVA: 0x003E7008 File Offset: 0x003E5208
			// (set) Token: 0x06010E21 RID: 69153 RVA: 0x00093051 File Offset: 0x00091251
			public unsafe IFilterConfigFactory m_FilterConfigFactory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_FilterConfigFactory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFilterConfigFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_FilterConfigFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057E2 RID: 22498
			// (get) Token: 0x06010E22 RID: 69154 RVA: 0x003E7038 File Offset: 0x003E5238
			// (set) Token: 0x06010E23 RID: 69155 RVA: 0x00093070 File Offset: 0x00091270
			public unsafe StaticVerticalGridScrollListUILogicalGroupT<Il2CppSystem.Object, UIElementCluster, UIButtonToggle> m_LogicalGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_LogicalGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Il2CppSystem.Object, UIElementCluster, UIButtonToggle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_LogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057E3 RID: 22499
			// (get) Token: 0x06010E24 RID: 69156 RVA: 0x003E7068 File Offset: 0x003E5268
			// (set) Token: 0x06010E25 RID: 69157 RVA: 0x0009308F File Offset: 0x0009128F
			public unsafe List<Il2CppSystem.Object> m_SelectedList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_SelectedList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_SelectedList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057E4 RID: 22500
			// (get) Token: 0x06010E26 RID: 69158 RVA: 0x003E7098 File Offset: 0x003E5298
			// (set) Token: 0x06010E27 RID: 69159 RVA: 0x000930AE File Offset: 0x000912AE
			public unsafe List<Il2CppSystem.Object> m_SelectionList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_SelectionList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr_m_SelectionList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057E5 RID: 22501
			// (get) Token: 0x06010E28 RID: 69160 RVA: 0x003E70C8 File Offset: 0x003E52C8
			// (set) Token: 0x06010E29 RID: 69161 RVA: 0x000930CD File Offset: 0x000912CD
			public unsafe uint _SelectionPriorityWeight_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField)) = value;
				}
			}

			// Token: 0x0400AACC RID: 43724
			private static readonly IntPtr NativeFieldInfoPtr_m_FilterConfigFactory;

			// Token: 0x0400AACD RID: 43725
			private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroup;

			// Token: 0x0400AACE RID: 43726
			private static readonly IntPtr NativeFieldInfoPtr_m_SelectedList;

			// Token: 0x0400AACF RID: 43727
			private static readonly IntPtr NativeFieldInfoPtr_m_SelectionList;

			// Token: 0x0400AAD0 RID: 43728
			private static readonly IntPtr NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField;

			// Token: 0x0400AAD1 RID: 43729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_UIElementCluster_IFilterConfig_IFilterConfigFactory_0;

			// Token: 0x0400AAD2 RID: 43730
			private static readonly IntPtr NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0;

			// Token: 0x0400AAD3 RID: 43731
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400AAD4 RID: 43732
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_IFilterConfig_0;

			// Token: 0x0400AAD5 RID: 43733
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400AAD6 RID: 43734
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Private_Void_Object_UIElementCluster_UIButtonToggle_0;

			// Token: 0x0400AAD7 RID: 43735
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_2_Private_Void_0;

			// Token: 0x0400AAD8 RID: 43736
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_1_Private_Void_Int32_MoveDirection_0;

			// Token: 0x020010C1 RID: 4289
			[ObfuscatedName("Common.UI.Filter.FlattenedFilterPanel+MultipleChoiceFilterUIController+<>c__DisplayClass4_0")]
			public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
			{
				// Token: 0x06012343 RID: 74563 RVA: 0x004268E0 File Offset: 0x00424AE0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_0()
				{
					Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, "<>c__DisplayClass4_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0>.NativeClassPtr);
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0>.NativeClassPtr, "obj");
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0>.NativeClassPtr, 100686465);
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0>.NativeClassPtr, 100686466);
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0>.NativeClassPtr, 100686467);
				}

				// Token: 0x06012344 RID: 74564 RVA: 0x00426970 File Offset: 0x00424B70
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012345 RID: 74565 RVA: 0x004269AC File Offset: 0x00424BAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282326, XrefRangeEnd = 282333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__3()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012346 RID: 74566 RVA: 0x004269E0 File Offset: 0x00424BE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282333, XrefRangeEnd = 282340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__4()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeMethodInfoPtr___ctor_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012347 RID: 74567 RVA: 0x0009E077 File Offset: 0x0009C277
				public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F34 RID: 24372
				// (get) Token: 0x06012348 RID: 74568 RVA: 0x00426A14 File Offset: 0x00424C14
				// (set) Token: 0x06012349 RID: 74569 RVA: 0x0009E080 File Offset: 0x0009C280
				public unsafe Il2CppSystem.Object obj
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeFieldInfoPtr_obj);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F35 RID: 24373
				// (get) Token: 0x0601234A RID: 74570 RVA: 0x00426A44 File Offset: 0x00424C44
				// (set) Token: 0x0601234B RID: 74571 RVA: 0x0009E09F File Offset: 0x0009C29F
				public unsafe FlattenedFilterPanel.MultipleChoiceFilterUIController __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlattenedFilterPanel.MultipleChoiceFilterUIController>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B885 RID: 47237
				private static readonly IntPtr NativeFieldInfoPtr_obj;

				// Token: 0x0400B886 RID: 47238
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B887 RID: 47239
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B888 RID: 47240
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_Internal_Void_0;

				// Token: 0x0400B889 RID: 47241
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_Internal_Void_0;
			}

			// Token: 0x020010C2 RID: 4290
			[ObfuscatedName("Common.UI.Filter.FlattenedFilterPanel+MultipleChoiceFilterUIController+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x0601234C RID: 74572 RVA: 0x00426A74 File Offset: 0x00424C74
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c>.NativeClassPtr);
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c>.NativeClassPtr, "<>9");
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c>.NativeClassPtr, "<>9__9_0");
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c>.NativeClassPtr, 100686469);
					FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeMethodInfoPtr__Release_b__9_0_Internal_GameObject_UILogicalUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c>.NativeClassPtr, 100686470);
				}

				// Token: 0x0601234D RID: 74573 RVA: 0x00426AF0 File Offset: 0x00424CF0
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601234E RID: 74574 RVA: 0x00426B2C File Offset: 0x00424D2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282340, XrefRangeEnd = 282342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GameObject _Release_b__9_0(UILogicalUnit x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeMethodInfoPtr__Release_b__9_0_Internal_GameObject_UILogicalUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
				}

				// Token: 0x0601234F RID: 74575 RVA: 0x0009E0BE File Offset: 0x0009C2BE
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F36 RID: 24374
				// (get) Token: 0x06012350 RID: 74576 RVA: 0x00426B7C File Offset: 0x00424D7C
				// (set) Token: 0x06012351 RID: 74577 RVA: 0x0009E0C7 File Offset: 0x0009C2C7
				public unsafe static FlattenedFilterPanel.MultipleChoiceFilterUIController.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlattenedFilterPanel.MultipleChoiceFilterUIController.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F37 RID: 24375
				// (get) Token: 0x06012352 RID: 74578 RVA: 0x00426BA4 File Offset: 0x00424DA4
				// (set) Token: 0x06012353 RID: 74579 RVA: 0x0009E0D9 File Offset: 0x0009C2D9
				public unsafe static Func<UILogicalUnit, GameObject> __9__9_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UILogicalUnit, GameObject>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(FlattenedFilterPanel.MultipleChoiceFilterUIController.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B88A RID: 47242
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B88B RID: 47243
				private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

				// Token: 0x0400B88C RID: 47244
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B88D RID: 47245
				private static readonly IntPtr NativeMethodInfoPtr__Release_b__9_0_Internal_GameObject_UILogicalUnit_0;
			}
		}

		// Token: 0x02000F09 RID: 3849
		public class SingleChoiceFilterUIController : Il2CppSystem.Object
		{
			// Token: 0x06010E2A RID: 69162 RVA: 0x003E70F0 File Offset: 0x003E52F0
			// Note: this type is marked as 'beforefieldinit'.
			static SingleChoiceFilterUIController()
			{
				Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "SingleChoiceFilterUIController");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr);
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_AllElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, "m_AllElements");
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, "m_Button");
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, "m_Field");
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_FilterConfigFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, "m_FilterConfigFactory");
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_LogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, "m_LogicalGroup");
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_CurrentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, "m_CurrentSelection");
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, "<SelectionPriorityWeight>k__BackingField");
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_UIElementCluster_IFilterConfig_IFilterConfigFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, 100686471);
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, 100686472);
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, 100686473);
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, 100686474);
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, 100686475);
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_UpdateElementsImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, 100686476);
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr__UpdateElementsImpl_b__13_0_Private_Void_UIElementCluster_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, 100686477);
				FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr__UpdateElementsImpl_b__13_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, 100686478);
			}

			// Token: 0x06010E2B RID: 69163 RVA: 0x003E7248 File Offset: 0x003E5448
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282566, RefRangeEnd = 282567, XrefRangeStart = 282532, XrefRangeEnd = 282566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleChoiceFilterUIController(UIElementCluster buttonPrefab, UIElementCluster moduleInstance, IFilterConfig filterConfig, IFilterConfigFactory filterConfigFactory) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttonPrefab);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moduleInstance);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterConfig);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterConfigFactory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_UIElementCluster_IFilterConfig_IFilterConfigFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170057EE RID: 22510
			// (get) Token: 0x06010E2C RID: 69164 RVA: 0x003E72CC File Offset: 0x003E54CC
			public unsafe virtual uint SelectionPriorityWeight
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06010E2D RID: 69165 RVA: 0x003E7308 File Offset: 0x003E5508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282567, XrefRangeEnd = 282572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Init()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E2E RID: 69166 RVA: 0x003E733C File Offset: 0x003E553C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282572, XrefRangeEnd = 282576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Select()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E2F RID: 69167 RVA: 0x003E7370 File Offset: 0x003E5570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282576, XrefRangeEnd = 282591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IFilterConfig Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_IFilterConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilterConfig>(intPtr3) : null;
			}

			// Token: 0x06010E30 RID: 69168 RVA: 0x003E73B0 File Offset: 0x003E55B0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 282623, RefRangeEnd = 282626, XrefRangeStart = 282591, XrefRangeEnd = 282623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateElementsImpl()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr_UpdateElementsImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E31 RID: 69169 RVA: 0x003E73E4 File Offset: 0x003E55E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282626, XrefRangeEnd = 282665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateElementsImpl_b__13_0(UIElementCluster ui, Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr__UpdateElementsImpl_b__13_0_Private_Void_UIElementCluster_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E32 RID: 69170 RVA: 0x003E7438 File Offset: 0x003E5638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282665, XrefRangeEnd = 282667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateElementsImpl_b__13_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeMethodInfoPtr__UpdateElementsImpl_b__13_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E33 RID: 69171 RVA: 0x000930E8 File Offset: 0x000912E8
			public SingleChoiceFilterUIController(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057E7 RID: 22503
			// (get) Token: 0x06010E34 RID: 69172 RVA: 0x003E746C File Offset: 0x003E566C
			// (set) Token: 0x06010E35 RID: 69173 RVA: 0x000930F1 File Offset: 0x000912F1
			public unsafe List<GameObject> m_AllElements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_AllElements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_AllElements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057E8 RID: 22504
			// (get) Token: 0x06010E36 RID: 69174 RVA: 0x003E749C File Offset: 0x003E569C
			// (set) Token: 0x06010E37 RID: 69175 RVA: 0x00093110 File Offset: 0x00091310
			public unsafe UIElementCluster m_Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_Button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057E9 RID: 22505
			// (get) Token: 0x06010E38 RID: 69176 RVA: 0x003E74CC File Offset: 0x003E56CC
			// (set) Token: 0x06010E39 RID: 69177 RVA: 0x0009312F File Offset: 0x0009132F
			public unsafe RectTransform m_Field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_Field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_Field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057EA RID: 22506
			// (get) Token: 0x06010E3A RID: 69178 RVA: 0x003E74FC File Offset: 0x003E56FC
			// (set) Token: 0x06010E3B RID: 69179 RVA: 0x0009314E File Offset: 0x0009134E
			public unsafe IFilterConfigFactory m_FilterConfigFactory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_FilterConfigFactory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFilterConfigFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_FilterConfigFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057EB RID: 22507
			// (get) Token: 0x06010E3C RID: 69180 RVA: 0x003E752C File Offset: 0x003E572C
			// (set) Token: 0x06010E3D RID: 69181 RVA: 0x0009316D File Offset: 0x0009136D
			public unsafe UILogicalGroup m_LogicalGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_LogicalGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_LogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057EC RID: 22508
			// (get) Token: 0x06010E3E RID: 69182 RVA: 0x003E755C File Offset: 0x003E575C
			// (set) Token: 0x06010E3F RID: 69183 RVA: 0x0009318C File Offset: 0x0009138C
			public unsafe Il2CppSystem.Object m_CurrentSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_CurrentSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr_m_CurrentSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057ED RID: 22509
			// (get) Token: 0x06010E40 RID: 69184 RVA: 0x003E758C File Offset: 0x003E578C
			// (set) Token: 0x06010E41 RID: 69185 RVA: 0x000931AB File Offset: 0x000913AB
			public unsafe uint _SelectionPriorityWeight_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField)) = value;
				}
			}

			// Token: 0x0400AAD9 RID: 43737
			private static readonly IntPtr NativeFieldInfoPtr_m_AllElements;

			// Token: 0x0400AADA RID: 43738
			private static readonly IntPtr NativeFieldInfoPtr_m_Button;

			// Token: 0x0400AADB RID: 43739
			private static readonly IntPtr NativeFieldInfoPtr_m_Field;

			// Token: 0x0400AADC RID: 43740
			private static readonly IntPtr NativeFieldInfoPtr_m_FilterConfigFactory;

			// Token: 0x0400AADD RID: 43741
			private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroup;

			// Token: 0x0400AADE RID: 43742
			private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelection;

			// Token: 0x0400AADF RID: 43743
			private static readonly IntPtr NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField;

			// Token: 0x0400AAE0 RID: 43744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIElementCluster_UIElementCluster_IFilterConfig_IFilterConfigFactory_0;

			// Token: 0x0400AAE1 RID: 43745
			private static readonly IntPtr NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0;

			// Token: 0x0400AAE2 RID: 43746
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400AAE3 RID: 43747
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400AAE4 RID: 43748
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_IFilterConfig_0;

			// Token: 0x0400AAE5 RID: 43749
			private static readonly IntPtr NativeMethodInfoPtr_UpdateElementsImpl_Private_Void_0;

			// Token: 0x0400AAE6 RID: 43750
			private static readonly IntPtr NativeMethodInfoPtr__UpdateElementsImpl_b__13_0_Private_Void_UIElementCluster_Object_0;

			// Token: 0x0400AAE7 RID: 43751
			private static readonly IntPtr NativeMethodInfoPtr__UpdateElementsImpl_b__13_1_Private_Void_0;

			// Token: 0x020010C3 RID: 4291
			[ObfuscatedName("Common.UI.Filter.FlattenedFilterPanel+SingleChoiceFilterUIController+<>c__DisplayClass13_0")]
			public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
			{
				// Token: 0x06012354 RID: 74580 RVA: 0x00426BCC File Offset: 0x00424DCC
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass13_0()
				{
					Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController>.NativeClassPtr, "<>c__DisplayClass13_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0>.NativeClassPtr);
					FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0>.NativeClassPtr, "obj");
					FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
					FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0>.NativeClassPtr, 100686479);
					FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeMethodInfoPtr__UpdateElementsImpl_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0>.NativeClassPtr, 100686480);
				}

				// Token: 0x06012355 RID: 74581 RVA: 0x00426C48 File Offset: 0x00424E48
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012356 RID: 74582 RVA: 0x00426C84 File Offset: 0x00424E84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282529, XrefRangeEnd = 282532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _UpdateElementsImpl_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeMethodInfoPtr__UpdateElementsImpl_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012357 RID: 74583 RVA: 0x0009E0EB File Offset: 0x0009C2EB
				public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F38 RID: 24376
				// (get) Token: 0x06012358 RID: 74584 RVA: 0x00426CB8 File Offset: 0x00424EB8
				// (set) Token: 0x06012359 RID: 74585 RVA: 0x0009E0F4 File Offset: 0x0009C2F4
				public unsafe Il2CppSystem.Object obj
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeFieldInfoPtr_obj);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F39 RID: 24377
				// (get) Token: 0x0601235A RID: 74586 RVA: 0x00426CE8 File Offset: 0x00424EE8
				// (set) Token: 0x0601235B RID: 74587 RVA: 0x0009E113 File Offset: 0x0009C313
				public unsafe FlattenedFilterPanel.SingleChoiceFilterUIController __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlattenedFilterPanel.SingleChoiceFilterUIController>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.SingleChoiceFilterUIController.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B88E RID: 47246
				private static readonly IntPtr NativeFieldInfoPtr_obj;

				// Token: 0x0400B88F RID: 47247
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B890 RID: 47248
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B891 RID: 47249
				private static readonly IntPtr NativeMethodInfoPtr__UpdateElementsImpl_b__2_Internal_Void_0;
			}
		}

		// Token: 0x02000F0A RID: 3850
		[ObfuscatedName("Common.UI.Filter.FlattenedFilterPanel+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x06010E42 RID: 69186 RVA: 0x003E75B4 File Offset: 0x003E57B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass13_0>.NativeClassPtr);
				FlattenedFilterPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass13_0>.NativeClassPtr, "module");
				FlattenedFilterPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass13_0>.NativeClassPtr, "field");
				FlattenedFilterPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass13_0>.NativeClassPtr, 100686481);
				FlattenedFilterPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass13_0>.NativeClassPtr, 100686482);
			}

			// Token: 0x06010E43 RID: 69187 RVA: 0x003E7630 File Offset: 0x003E5830
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E44 RID: 69188 RVA: 0x003E766C File Offset: 0x003E586C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282667, XrefRangeEnd = 282673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIElementCluster _OnPanelInitialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
			}

			// Token: 0x06010E45 RID: 69189 RVA: 0x000931C6 File Offset: 0x000913C6
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057EF RID: 22511
			// (get) Token: 0x06010E46 RID: 69190 RVA: 0x003E76AC File Offset: 0x003E58AC
			// (set) Token: 0x06010E47 RID: 69191 RVA: 0x000931CF File Offset: 0x000913CF
			public unsafe UIElementCluster module
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_module);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057F0 RID: 22512
			// (get) Token: 0x06010E48 RID: 69192 RVA: 0x003E76DC File Offset: 0x003E58DC
			// (set) Token: 0x06010E49 RID: 69193 RVA: 0x000931EE File Offset: 0x000913EE
			public unsafe Transform field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AAE8 RID: 43752
			private static readonly IntPtr NativeFieldInfoPtr_module;

			// Token: 0x0400AAE9 RID: 43753
			private static readonly IntPtr NativeFieldInfoPtr_field;

			// Token: 0x0400AAEA RID: 43754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AAEB RID: 43755
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_UIElementCluster_0;
		}

		// Token: 0x02000F0B RID: 3851
		[ObfuscatedName("Common.UI.Filter.FlattenedFilterPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010E4A RID: 69194 RVA: 0x003E770C File Offset: 0x003E590C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr);
				FlattenedFilterPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, "<>9");
				FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, "<>9__13_2");
				FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, "<>9__13_3");
				FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, "<>9__13_4");
				FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, "<>9__14_0");
				FlattenedFilterPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, 100686484);
				FlattenedFilterPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, 100686485);
				FlattenedFilterPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_3_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, 100686486);
				FlattenedFilterPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_4_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, 100686487);
				FlattenedFilterPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__14_0_Internal_UInt32_IFilterUIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr, 100686488);
			}

			// Token: 0x06010E4B RID: 69195 RVA: 0x003E7800 File Offset: 0x003E5A00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E4C RID: 69196 RVA: 0x003E783C File Offset: 0x003E5A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282673, XrefRangeEnd = 282678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13_2(UIElementCluster instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E4D RID: 69197 RVA: 0x003E7880 File Offset: 0x003E5A80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13_3(UIElementCluster instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_3_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E4E RID: 69198 RVA: 0x003E78C4 File Offset: 0x003E5AC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282678, XrefRangeEnd = 282684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13_4(UIElementCluster instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__13_4_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E4F RID: 69199 RVA: 0x003E7908 File Offset: 0x003E5B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282684, XrefRangeEnd = 282688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _OnPanelOpen_b__14_0(FlattenedFilterPanel.IFilterUIController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__14_0_Internal_UInt32_IFilterUIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010E50 RID: 69200 RVA: 0x0009320D File Offset: 0x0009140D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057F1 RID: 22513
			// (get) Token: 0x06010E51 RID: 69201 RVA: 0x003E7958 File Offset: 0x003E5B58
			// (set) Token: 0x06010E52 RID: 69202 RVA: 0x00093216 File Offset: 0x00091416
			public unsafe static FlattenedFilterPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlattenedFilterPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057F2 RID: 22514
			// (get) Token: 0x06010E53 RID: 69203 RVA: 0x003E7980 File Offset: 0x003E5B80
			// (set) Token: 0x06010E54 RID: 69204 RVA: 0x00093228 File Offset: 0x00091428
			public unsafe static Action<UIElementCluster> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057F3 RID: 22515
			// (get) Token: 0x06010E55 RID: 69205 RVA: 0x003E79A8 File Offset: 0x003E5BA8
			// (set) Token: 0x06010E56 RID: 69206 RVA: 0x0009323A File Offset: 0x0009143A
			public unsafe static Action<UIElementCluster> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057F4 RID: 22516
			// (get) Token: 0x06010E57 RID: 69207 RVA: 0x003E79D0 File Offset: 0x003E5BD0
			// (set) Token: 0x06010E58 RID: 69208 RVA: 0x0009324C File Offset: 0x0009144C
			public unsafe static Action<UIElementCluster> __9__13_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057F5 RID: 22517
			// (get) Token: 0x06010E59 RID: 69209 RVA: 0x003E79F8 File Offset: 0x003E5BF8
			// (set) Token: 0x06010E5A RID: 69210 RVA: 0x0009325E File Offset: 0x0009145E
			public unsafe static Func<FlattenedFilterPanel.IFilterUIController, uint> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FlattenedFilterPanel.IFilterUIController, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlattenedFilterPanel.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AAEC RID: 43756
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AAED RID: 43757
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x0400AAEE RID: 43758
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x0400AAEF RID: 43759
			private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

			// Token: 0x0400AAF0 RID: 43760
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400AAF1 RID: 43761
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AAF2 RID: 43762
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_2_Internal_Void_UIElementCluster_0;

			// Token: 0x0400AAF3 RID: 43763
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_3_Internal_Void_UIElementCluster_0;

			// Token: 0x0400AAF4 RID: 43764
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_4_Internal_Void_UIElementCluster_0;

			// Token: 0x0400AAF5 RID: 43765
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__14_0_Internal_UInt32_IFilterUIController_0;
		}

		// Token: 0x02000F0C RID: 3852
		[ObfuscatedName("Common.UI.Filter.FlattenedFilterPanel+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x06010E5B RID: 69211 RVA: 0x003E7A20 File Offset: 0x003E5C20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlattenedFilterPanel>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass14_0>.NativeClassPtr);
				FlattenedFilterPanel.__c__DisplayClass14_0.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass14_0>.NativeClassPtr, "factory");
				FlattenedFilterPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass14_0>.NativeClassPtr, 100686489);
				FlattenedFilterPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass14_0>.NativeClassPtr, 100686490);
			}

			// Token: 0x06010E5C RID: 69212 RVA: 0x003E7A88 File Offset: 0x003E5C88
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlattenedFilterPanel.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010E5D RID: 69213 RVA: 0x003E7AC4 File Offset: 0x003E5CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282688, XrefRangeEnd = 282691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__1(IFilterConfig config)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlattenedFilterPanel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_IFilterConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010E5E RID: 69214 RVA: 0x00093270 File Offset: 0x00091470
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057F6 RID: 22518
			// (get) Token: 0x06010E5F RID: 69215 RVA: 0x003E7B14 File Offset: 0x003E5D14
			// (set) Token: 0x06010E60 RID: 69216 RVA: 0x00093279 File Offset: 0x00091479
			public unsafe IFilterConfigFactory factory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.__c__DisplayClass14_0.NativeFieldInfoPtr_factory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFilterConfigFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlattenedFilterPanel.__c__DisplayClass14_0.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AAF6 RID: 43766
			private static readonly IntPtr NativeFieldInfoPtr_factory;

			// Token: 0x0400AAF7 RID: 43767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AAF8 RID: 43768
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Boolean_IFilterConfig_0;
		}
	}
}
