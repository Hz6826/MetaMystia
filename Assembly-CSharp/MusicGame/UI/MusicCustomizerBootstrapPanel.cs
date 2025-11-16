using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace MusicGame.UI
{
	// Token: 0x0200001A RID: 26
	public class MusicCustomizerBootstrapPanel : UIPanel
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x000A51BC File Offset: 0x000A33BC
		// Note: this type is marked as 'beforefieldinit'.
		static MusicCustomizerBootstrapPanel()
		{
			Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicCustomizerBootstrapPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr);
			MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_MapCreatorExeRelativePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, "MapCreatorExeRelativePath");
			MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_MapPlayerExeRelativePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, "MapPlayerExeRelativePath");
			MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_LaunchMapPlayerBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, "m_LaunchMapPlayerBtn");
			MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_LaunchMapCreatorBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, "m_LaunchMapCreatorBtn");
			MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_BackBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, "m_BackBtn");
			MusicCustomizerBootstrapPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, 100663563);
			MusicCustomizerBootstrapPanel.NativeMethodInfoPtr_Launch_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, 100663564);
			MusicCustomizerBootstrapPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, 100663565);
			MusicCustomizerBootstrapPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, 100663566);
			MusicCustomizerBootstrapPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, 100663567);
			MusicCustomizerBootstrapPanel.NativeMethodInfoPtr__OnPanelInitialize_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, 100663568);
			MusicCustomizerBootstrapPanel.NativeMethodInfoPtr__OnPanelInitialize_b__5_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr, 100663569);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000A52DC File Offset: 0x000A34DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19193, XrefRangeEnd = 19215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicCustomizerBootstrapPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000A5318 File Offset: 0x000A3518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19228, RefRangeEnd = 19230, XrefRangeStart = 19215, XrefRangeEnd = 19228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Launch(string fileName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicCustomizerBootstrapPanel.NativeMethodInfoPtr_Launch_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000A535C File Offset: 0x000A355C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19230, XrefRangeEnd = 19231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicCustomizerBootstrapPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000A5398 File Offset: 0x000A3598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19231, XrefRangeEnd = 19235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicCustomizerBootstrapPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000A53D4 File Offset: 0x000A35D4
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicCustomizerBootstrapPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicCustomizerBootstrapPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicCustomizerBootstrapPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000A5410 File Offset: 0x000A3610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19235, XrefRangeEnd = 19238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicCustomizerBootstrapPanel.NativeMethodInfoPtr__OnPanelInitialize_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000A5444 File Offset: 0x000A3644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19238, XrefRangeEnd = 19241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__5_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicCustomizerBootstrapPanel.NativeMethodInfoPtr__OnPanelInitialize_b__5_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002F48 File Offset: 0x00001148
		public MusicCustomizerBootstrapPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000A5478 File Offset: 0x000A3678
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002F51 File Offset: 0x00001151
		public unsafe static string MapCreatorExeRelativePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_MapCreatorExeRelativePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_MapCreatorExeRelativePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000A5498 File Offset: 0x000A3698
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002F63 File Offset: 0x00001163
		public unsafe static string MapPlayerExeRelativePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_MapPlayerExeRelativePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_MapPlayerExeRelativePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000A54B8 File Offset: 0x000A36B8
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002F75 File Offset: 0x00001175
		public unsafe UIButtonSimple m_LaunchMapPlayerBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_LaunchMapPlayerBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_LaunchMapPlayerBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000A54E8 File Offset: 0x000A36E8
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002F94 File Offset: 0x00001194
		public unsafe UIButtonSimple m_LaunchMapCreatorBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_LaunchMapCreatorBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_LaunchMapCreatorBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000A5518 File Offset: 0x000A3718
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002FB3 File Offset: 0x000011B3
		public unsafe UIButtonSimple m_BackBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_BackBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicCustomizerBootstrapPanel.NativeFieldInfoPtr_m_BackBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_MapCreatorExeRelativePath;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_MapPlayerExeRelativePath;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_m_LaunchMapPlayerBtn;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_m_LaunchMapCreatorBtn;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_m_BackBtn;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_Launch_Private_Void_String_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__5_0_Private_Void_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__5_1_Private_Void_0;
	}
}
