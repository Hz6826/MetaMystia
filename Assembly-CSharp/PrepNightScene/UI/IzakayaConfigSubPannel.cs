using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace PrepNightScene.UI
{
	// Token: 0x0200003E RID: 62
	public class IzakayaConfigSubPannel : UISubPanel<IzakayaConfigPannel>
	{
		// Token: 0x0600071E RID: 1822 RVA: 0x000B4954 File Offset: 0x000B2B54
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaConfigSubPannel()
		{
			Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrepNightScene.UI", "IzakayaConfigSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr);
			IzakayaConfigSubPannel.NativeFieldInfoPtr_NoteBookBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, "NoteBookBtn");
			IzakayaConfigSubPannel.NativeFieldInfoPtr_StorageBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, "StorageBtn");
			IzakayaConfigSubPannel.NativeFieldInfoPtr_PresetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, "PresetBtn");
			IzakayaConfigSubPannel.NativeFieldInfoPtr_FilterBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, "FilterBtn");
			IzakayaConfigSubPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, "SubPannel");
			IzakayaConfigSubPannel.NativeFieldInfoPtr_m_LogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, "m_LogicalGroup");
			IzakayaConfigSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, 100664428);
			IzakayaConfigSubPannel.NativeMethodInfoPtr_SetLogicalGroup_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, 100664429);
			IzakayaConfigSubPannel.NativeMethodInfoPtr_OpenPreset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, 100664430);
			IzakayaConfigSubPannel.NativeMethodInfoPtr_OpenFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, 100664431);
			IzakayaConfigSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, 100664432);
			IzakayaConfigSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, 100664433);
			IzakayaConfigSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, 100664434);
			IzakayaConfigSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, 100664435);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000B4A9C File Offset: 0x000B2C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29848, RefRangeEnd = 29849, XrefRangeStart = 29801, XrefRangeEnd = 29848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000B4AD8 File Offset: 0x000B2CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29849, XrefRangeEnd = 29871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLogicalGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigSubPannel.NativeMethodInfoPtr_SetLogicalGroup_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000B4B14 File Offset: 0x000B2D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29871, XrefRangeEnd = 29883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPreset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigSubPannel.NativeMethodInfoPtr_OpenPreset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000B4B48 File Offset: 0x000B2D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29883, XrefRangeEnd = 29889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigSubPannel.NativeMethodInfoPtr_OpenFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000B4B7C File Offset: 0x000B2D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29889, XrefRangeEnd = 29894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigSubPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000B4BB8 File Offset: 0x000B2DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29894, XrefRangeEnd = 29898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000B4BF4 File Offset: 0x000B2DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29898, XrefRangeEnd = 29905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000B4C30 File Offset: 0x000B2E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29905, XrefRangeEnd = 29908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaConfigSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000063DC File Offset: 0x000045DC
		public IzakayaConfigSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x000B4C6C File Offset: 0x000B2E6C
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000063E5 File Offset: 0x000045E5
		public unsafe UIButtonSimple NoteBookBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_NoteBookBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_NoteBookBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000B4C9C File Offset: 0x000B2E9C
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00006404 File Offset: 0x00004604
		public unsafe UIButtonSimple StorageBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_StorageBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_StorageBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000B4CCC File Offset: 0x000B2ECC
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00006423 File Offset: 0x00004623
		public unsafe UIButtonSimple PresetBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_PresetBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_PresetBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x000B4CFC File Offset: 0x000B2EFC
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00006442 File Offset: 0x00004642
		public unsafe UIButtonSimple FilterBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_FilterBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_FilterBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000B4D2C File Offset: 0x000B2F2C
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00006461 File Offset: 0x00004661
		public unsafe IzakayaPresetPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaPresetPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000B4D5C File Offset: 0x000B2F5C
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00006480 File Offset: 0x00004680
		public unsafe UILogicalGroup m_LogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_m_LogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigSubPannel.NativeFieldInfoPtr_m_LogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_NoteBookBtn;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_StorageBtn;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_PresetBtn;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_FilterBtn;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroup;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_SetLogicalGroup_Protected_Virtual_New_Void_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_OpenPreset_Private_Void_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilter_Private_Void_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004EC RID: 1260
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigSubPannel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600826A RID: 33386 RVA: 0x0024C214 File Offset: 0x0024A414
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigSubPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr);
				IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr, "<>9");
				IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr, "<>9__6_0");
				IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr, "<>9__6_1");
				IzakayaConfigSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr, 100664437);
				IzakayaConfigSubPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr, 100664438);
				IzakayaConfigSubPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr, 100664439);
			}

			// Token: 0x0600826B RID: 33387 RVA: 0x0024C2B8 File Offset: 0x0024A4B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigSubPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600826C RID: 33388 RVA: 0x0024C2F4 File Offset: 0x0024A4F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29793, XrefRangeEnd = 29797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__6_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigSubPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600826D RID: 33389 RVA: 0x0024C328 File Offset: 0x0024A528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29797, XrefRangeEnd = 29801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__6_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigSubPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600826E RID: 33390 RVA: 0x000466C7 File Offset: 0x000448C7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BE8 RID: 11240
			// (get) Token: 0x0600826F RID: 33391 RVA: 0x0024C35C File Offset: 0x0024A55C
			// (set) Token: 0x06008270 RID: 33392 RVA: 0x000466D0 File Offset: 0x000448D0
			public unsafe static IzakayaConfigSubPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigSubPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BE9 RID: 11241
			// (get) Token: 0x06008271 RID: 33393 RVA: 0x0024C384 File Offset: 0x0024A584
			// (set) Token: 0x06008272 RID: 33394 RVA: 0x000466E2 File Offset: 0x000448E2
			public unsafe static Action __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BEA RID: 11242
			// (get) Token: 0x06008273 RID: 33395 RVA: 0x0024C3AC File Offset: 0x0024A5AC
			// (set) Token: 0x06008274 RID: 33396 RVA: 0x000466F4 File Offset: 0x000448F4
			public unsafe static Action __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigSubPannel.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400556F RID: 21871
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005570 RID: 21872
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04005571 RID: 21873
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04005572 RID: 21874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005573 RID: 21875
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Internal_Void_0;

			// Token: 0x04005574 RID: 21876
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Internal_Void_0;
		}
	}
}
