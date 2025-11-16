using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000372 RID: 882
	public class GuideMapSpotIzakayaExtension : MonoBehaviour
	{
		// Token: 0x060068B7 RID: 26807 RVA: 0x001FBF20 File Offset: 0x001FA120
		// Note: this type is marked as 'beforefieldinit'.
		static GuideMapSpotIzakayaExtension()
		{
			Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "GuideMapSpotIzakayaExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr);
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_IzakayaSpotVisualSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_IzakayaSpotVisualSelected");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level1FG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_Level1FG");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level2FG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_Level2FG");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level3FG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_Level3FG");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level1FG_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_Level1FG_Selected");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level2FG_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_Level2FG_Selected");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level3FG_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_Level3FG_Selected");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_LockedIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_LockedIndicator");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_SelfPointImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_SelfPointImage");
			GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, "m_CanvasGroup");
			GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, 100685082);
			GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_Setup_Public_Void_IzakayaLevel_UIButtonSimple_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, 100685083);
			GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, 100685084);
			GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_SetPointStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, 100685085);
			GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, 100685086);
			GuideMapSpotIzakayaExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, 100685087);
			GuideMapSpotIzakayaExtension.NativeMethodInfoPtr__Setup_b__11_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, 100685088);
			GuideMapSpotIzakayaExtension.NativeMethodInfoPtr__Setup_b__11_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr, 100685089);
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x001FC0B8 File Offset: 0x001FA2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268009, XrefRangeEnd = 268018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x001FC0EC File Offset: 0x001FA2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268039, RefRangeEnd = 268040, XrefRangeStart = 268018, XrefRangeEnd = 268039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(IzakayaLevel maxLevel, UIButtonSimple uiButtonSimple, bool enableLockedIndicator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableLockedIndicator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_Setup_Public_Void_IzakayaLevel_UIButtonSimple_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x001FC14C File Offset: 0x001FA34C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x001FC180 File Offset: 0x001FA380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268052, RefRangeEnd = 268054, XrefRangeStart = 268040, XrefRangeEnd = 268052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPointStatus(bool isActived)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActived;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_SetPointStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x001FC1C0 File Offset: 0x001FA3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapSpotIzakayaExtension.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x001FC1FC File Offset: 0x001FA3FC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuideMapSpotIzakayaExtension() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapSpotIzakayaExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpotIzakayaExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x001FC238 File Offset: 0x001FA438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268054, XrefRangeEnd = 268059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Setup_b__11_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpotIzakayaExtension.NativeMethodInfoPtr__Setup_b__11_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x001FC26C File Offset: 0x001FA46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268059, XrefRangeEnd = 268064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Setup_b__11_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapSpotIzakayaExtension.NativeMethodInfoPtr__Setup_b__11_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x000389CA File Offset: 0x00036BCA
		public GuideMapSpotIzakayaExtension(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x060068C1 RID: 26817 RVA: 0x001FC2A0 File Offset: 0x001FA4A0
		// (set) Token: 0x060068C2 RID: 26818 RVA: 0x000389D3 File Offset: 0x00036BD3
		public unsafe Image m_IzakayaSpotVisualSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_IzakayaSpotVisualSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_IzakayaSpotVisualSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x060068C3 RID: 26819 RVA: 0x001FC2D0 File Offset: 0x001FA4D0
		// (set) Token: 0x060068C4 RID: 26820 RVA: 0x000389F2 File Offset: 0x00036BF2
		public unsafe Image m_Level1FG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level1FG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level1FG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x060068C5 RID: 26821 RVA: 0x001FC300 File Offset: 0x001FA500
		// (set) Token: 0x060068C6 RID: 26822 RVA: 0x00038A11 File Offset: 0x00036C11
		public unsafe Image m_Level2FG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level2FG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level2FG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x060068C7 RID: 26823 RVA: 0x001FC330 File Offset: 0x001FA530
		// (set) Token: 0x060068C8 RID: 26824 RVA: 0x00038A30 File Offset: 0x00036C30
		public unsafe Image m_Level3FG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level3FG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level3FG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x060068C9 RID: 26825 RVA: 0x001FC360 File Offset: 0x001FA560
		// (set) Token: 0x060068CA RID: 26826 RVA: 0x00038A4F File Offset: 0x00036C4F
		public unsafe Image m_Level1FG_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level1FG_Selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level1FG_Selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x060068CB RID: 26827 RVA: 0x001FC390 File Offset: 0x001FA590
		// (set) Token: 0x060068CC RID: 26828 RVA: 0x00038A6E File Offset: 0x00036C6E
		public unsafe Image m_Level2FG_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level2FG_Selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level2FG_Selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x060068CD RID: 26829 RVA: 0x001FC3C0 File Offset: 0x001FA5C0
		// (set) Token: 0x060068CE RID: 26830 RVA: 0x00038A8D File Offset: 0x00036C8D
		public unsafe Image m_Level3FG_Selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level3FG_Selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_Level3FG_Selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x060068CF RID: 26831 RVA: 0x001FC3F0 File Offset: 0x001FA5F0
		// (set) Token: 0x060068D0 RID: 26832 RVA: 0x00038AAC File Offset: 0x00036CAC
		public unsafe Image m_LockedIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_LockedIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_LockedIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x060068D1 RID: 26833 RVA: 0x001FC420 File Offset: 0x001FA620
		// (set) Token: 0x060068D2 RID: 26834 RVA: 0x00038ACB File Offset: 0x00036CCB
		public unsafe Image m_SelfPointImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_SelfPointImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_SelfPointImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x060068D3 RID: 26835 RVA: 0x001FC450 File Offset: 0x001FA650
		// (set) Token: 0x060068D4 RID: 26836 RVA: 0x00038AEA File Offset: 0x00036CEA
		public unsafe CanvasGroup m_CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapSpotIzakayaExtension.NativeFieldInfoPtr_m_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400456D RID: 17773
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaSpotVisualSelected;

		// Token: 0x0400456E RID: 17774
		private static readonly IntPtr NativeFieldInfoPtr_m_Level1FG;

		// Token: 0x0400456F RID: 17775
		private static readonly IntPtr NativeFieldInfoPtr_m_Level2FG;

		// Token: 0x04004570 RID: 17776
		private static readonly IntPtr NativeFieldInfoPtr_m_Level3FG;

		// Token: 0x04004571 RID: 17777
		private static readonly IntPtr NativeFieldInfoPtr_m_Level1FG_Selected;

		// Token: 0x04004572 RID: 17778
		private static readonly IntPtr NativeFieldInfoPtr_m_Level2FG_Selected;

		// Token: 0x04004573 RID: 17779
		private static readonly IntPtr NativeFieldInfoPtr_m_Level3FG_Selected;

		// Token: 0x04004574 RID: 17780
		private static readonly IntPtr NativeFieldInfoPtr_m_LockedIndicator;

		// Token: 0x04004575 RID: 17781
		private static readonly IntPtr NativeFieldInfoPtr_m_SelfPointImage;

		// Token: 0x04004576 RID: 17782
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroup;

		// Token: 0x04004577 RID: 17783
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004578 RID: 17784
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_IzakayaLevel_UIButtonSimple_Boolean_0;

		// Token: 0x04004579 RID: 17785
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400457A RID: 17786
		private static readonly IntPtr NativeMethodInfoPtr_SetPointStatus_Public_Void_Boolean_0;

		// Token: 0x0400457B RID: 17787
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400457C RID: 17788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400457D RID: 17789
		private static readonly IntPtr NativeMethodInfoPtr__Setup_b__11_0_Private_Void_0;

		// Token: 0x0400457E RID: 17790
		private static readonly IntPtr NativeMethodInfoPtr__Setup_b__11_1_Private_Void_0;
	}
}
