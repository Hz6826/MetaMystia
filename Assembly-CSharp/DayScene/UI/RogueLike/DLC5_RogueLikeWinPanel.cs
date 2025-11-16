using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000128 RID: 296
	public class DLC5_RogueLikeWinPanel : UIPanelParam<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext, DLC5_RogueLikeWinPanel.CloseContext>
	{
		// Token: 0x06002244 RID: 8772 RVA: 0x0010FDDC File Offset: 0x0010DFDC
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeWinPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeWinPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr);
			DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_ContinueBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, "m_ContinueBtn");
			DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_SettleBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, "m_SettleBtn");
			DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_BreakBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, "m_BreakBtn");
			DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_FirstSelectBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, "m_FirstSelectBtn");
			DLC5_RogueLikeWinPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, 100669404);
			DLC5_RogueLikeWinPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueConfirmPanelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, 100669405);
			DLC5_RogueLikeWinPanel.NativeMethodInfoPtr_TryClosePanel_Private_UniTask_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, 100669406);
			DLC5_RogueLikeWinPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, 100669407);
			DLC5_RogueLikeWinPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, 100669408);
			DLC5_RogueLikeWinPanel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, 100669409);
			DLC5_RogueLikeWinPanel.NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, 100669410);
			DLC5_RogueLikeWinPanel.NativeMethodInfoPtr__OnPanelInitialize_b__6_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, 100669411);
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0010FEFC File Offset: 0x0010E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83424, XrefRangeEnd = 83454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeWinPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0010FF38 File Offset: 0x0010E138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83454, XrefRangeEnd = 83463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeWinPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueConfirmPanelOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0010FF8C File Offset: 0x0010E18C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83469, RefRangeEnd = 83471, XrefRangeStart = 83463, XrefRangeEnd = 83469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask TryClosePanel(DLC5_RogueLikeWinPanel.CloseContext closeContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closeContext;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel.NativeMethodInfoPtr_TryClosePanel_Private_UniTask_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0010FFD0 File Offset: 0x0010E1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83471, XrefRangeEnd = 83475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeWinPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0011000C File Offset: 0x0010E20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83475, XrefRangeEnd = 83478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeWinPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00110048 File Offset: 0x0010E248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83478, XrefRangeEnd = 83480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel.NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x0011007C File Offset: 0x0010E27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83480, XrefRangeEnd = 83483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel.NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x001100B0 File Offset: 0x0010E2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83483, XrefRangeEnd = 83485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__6_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel.NativeMethodInfoPtr__OnPanelInitialize_b__6_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00014DDE File Offset: 0x00012FDE
		public DLC5_RogueLikeWinPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x001100E4 File Offset: 0x0010E2E4
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00014DE7 File Offset: 0x00012FE7
		public unsafe UIButtonSimple m_ContinueBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_ContinueBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_ContinueBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x00110114 File Offset: 0x0010E314
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00014E06 File Offset: 0x00013006
		public unsafe UIButtonSimple m_SettleBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_SettleBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_SettleBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00110144 File Offset: 0x0010E344
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00014E25 File Offset: 0x00013025
		public unsafe UIButtonSimple m_BreakBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_BreakBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_BreakBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00110174 File Offset: 0x0010E374
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00014E44 File Offset: 0x00013044
		public unsafe DLC5_RogueLikeWinPanel.CloseContext m_FirstSelectBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_FirstSelectBtn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.NativeFieldInfoPtr_m_FirstSelectBtn)) = value;
			}
		}

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeFieldInfoPtr_m_ContinueBtn;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeFieldInfoPtr_m_SettleBtn;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeFieldInfoPtr_m_BreakBtn;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstSelectBtn;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_RogueConfirmPanelOpenContext_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_TryClosePanel_Private_UniTask_CloseContext_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_0_Private_Void_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_1_Private_Void_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_2_Private_Void_0;

		// Token: 0x0200074C RID: 1868
		public sealed class RogueConfirmPanelOpenContext : ValueType
		{
			// Token: 0x06009F49 RID: 40777 RVA: 0x002A1250 File Offset: 0x0029F450
			// Note: this type is marked as 'beforefieldinit'.
			static RogueConfirmPanelOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, "RogueConfirmPanelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext>.NativeClassPtr);
				DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext>.NativeClassPtr, "RogueLikeRunTimeData");
				DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext.NativeFieldInfoPtr_NeedFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext>.NativeClassPtr, "NeedFadeIn");
				DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext>.NativeClassPtr, 100669412);
			}

			// Token: 0x06009F4A RID: 40778 RVA: 0x002A12B8 File Offset: 0x0029F4B8
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 60822, RefRangeEnd = 60840, XrefRangeStart = 60822, XrefRangeEnd = 60840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueConfirmPanelOpenContext(RogueLikeRunTimeData rogueLikeRunTimeData, bool needFadeIn) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFadeIn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F4B RID: 40779 RVA: 0x0005611A File Offset: 0x0005431A
			public RogueConfirmPanelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009F4C RID: 40780 RVA: 0x00056123 File Offset: 0x00054323
			public RogueConfirmPanelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700349D RID: 13469
			// (get) Token: 0x06009F4D RID: 40781 RVA: 0x002A1318 File Offset: 0x0029F518
			// (set) Token: 0x06009F4E RID: 40782 RVA: 0x00056135 File Offset: 0x00054335
			public unsafe RogueLikeRunTimeData RogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700349E RID: 13470
			// (get) Token: 0x06009F4F RID: 40783 RVA: 0x002A1348 File Offset: 0x0029F548
			// (set) Token: 0x06009F50 RID: 40784 RVA: 0x00056154 File Offset: 0x00054354
			public unsafe bool NeedFadeIn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext.NativeFieldInfoPtr_NeedFadeIn);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext.NativeFieldInfoPtr_NeedFadeIn)) = value;
				}
			}

			// Token: 0x0400674C RID: 26444
			private static readonly IntPtr NativeFieldInfoPtr_RogueLikeRunTimeData;

			// Token: 0x0400674D RID: 26445
			private static readonly IntPtr NativeFieldInfoPtr_NeedFadeIn;

			// Token: 0x0400674E RID: 26446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_Boolean_0;
		}

		// Token: 0x0200074D RID: 1869
		public enum CloseContext
		{
			// Token: 0x04006750 RID: 26448
			Continue,
			// Token: 0x04006751 RID: 26449
			Exit,
			// Token: 0x04006752 RID: 26450
			Settle
		}

		// Token: 0x0200074E RID: 1870
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeWinPanel+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06009F51 RID: 40785 RVA: 0x002A1370 File Offset: 0x0029F570
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.__c__DisplayClass8_0>.NativeClassPtr);
				DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_closeContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.__c__DisplayClass8_0>.NativeClassPtr, "closeContext");
				DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.__c__DisplayClass8_0>.NativeClassPtr, 100669413);
				DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__TryClosePanel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.__c__DisplayClass8_0>.NativeClassPtr, 100669414);
			}

			// Token: 0x06009F52 RID: 40786 RVA: 0x002A13EC File Offset: 0x0029F5EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F53 RID: 40787 RVA: 0x002A1428 File Offset: 0x0029F628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83407, XrefRangeEnd = 83411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryClosePanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__TryClosePanel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F54 RID: 40788 RVA: 0x0005616F File Offset: 0x0005436F
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700349F RID: 13471
			// (get) Token: 0x06009F55 RID: 40789 RVA: 0x002A145C File Offset: 0x0029F65C
			// (set) Token: 0x06009F56 RID: 40790 RVA: 0x00056178 File Offset: 0x00054378
			public unsafe DLC5_RogueLikeWinPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeWinPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034A0 RID: 13472
			// (get) Token: 0x06009F57 RID: 40791 RVA: 0x002A148C File Offset: 0x0029F68C
			// (set) Token: 0x06009F58 RID: 40792 RVA: 0x00056197 File Offset: 0x00054397
			public unsafe DLC5_RogueLikeWinPanel.CloseContext closeContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_closeContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_closeContext)) = value;
				}
			}

			// Token: 0x04006753 RID: 26451
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006754 RID: 26452
			private static readonly IntPtr NativeFieldInfoPtr_closeContext;

			// Token: 0x04006755 RID: 26453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006756 RID: 26454
			private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__0_Internal_Void_0;
		}

		// Token: 0x0200074F RID: 1871
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeWinPanel+<TryClosePanel>d__8")]
		public sealed class _TryClosePanel_d__8 : ValueType
		{
			// Token: 0x06009F59 RID: 40793 RVA: 0x002A14B4 File Offset: 0x0029F6B4
			// Note: this type is marked as 'beforefieldinit'.
			static _TryClosePanel_d__8()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel>.NativeClassPtr, "<TryClosePanel>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr);
				DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr_closeContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr, "closeContext");
				DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr, 100669415);
				DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr, 100669416);
			}

			// Token: 0x06009F5A RID: 40794 RVA: 0x002A156C File Offset: 0x0029F76C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 83421, RefRangeEnd = 83424, XrefRangeStart = 83411, XrefRangeEnd = 83421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F5B RID: 40795 RVA: 0x002A15A4 File Offset: 0x0029F7A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F5C RID: 40796 RVA: 0x000561B2 File Offset: 0x000543B2
			public _TryClosePanel_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009F5D RID: 40797 RVA: 0x000561BB File Offset: 0x000543BB
			public _TryClosePanel_d__8() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeWinPanel._TryClosePanel_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x170034A1 RID: 13473
			// (get) Token: 0x06009F5E RID: 40798 RVA: 0x002A15EC File Offset: 0x0029F7EC
			// (set) Token: 0x06009F5F RID: 40799 RVA: 0x000561CD File Offset: 0x000543CD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170034A2 RID: 13474
			// (get) Token: 0x06009F60 RID: 40800 RVA: 0x002A1614 File Offset: 0x0029F814
			// (set) Token: 0x06009F61 RID: 40801 RVA: 0x000561E8 File Offset: 0x000543E8
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170034A3 RID: 13475
			// (get) Token: 0x06009F62 RID: 40802 RVA: 0x002A1644 File Offset: 0x0029F844
			// (set) Token: 0x06009F63 RID: 40803 RVA: 0x00056216 File Offset: 0x00054416
			public unsafe DLC5_RogueLikeWinPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeWinPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034A4 RID: 13476
			// (get) Token: 0x06009F64 RID: 40804 RVA: 0x002A1674 File Offset: 0x0029F874
			// (set) Token: 0x06009F65 RID: 40805 RVA: 0x00056235 File Offset: 0x00054435
			public unsafe DLC5_RogueLikeWinPanel.CloseContext closeContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr_closeContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr_closeContext)) = value;
				}
			}

			// Token: 0x170034A5 RID: 13477
			// (get) Token: 0x06009F66 RID: 40806 RVA: 0x002A169C File Offset: 0x0029F89C
			// (set) Token: 0x06009F67 RID: 40807 RVA: 0x00056250 File Offset: 0x00054450
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeWinPanel._TryClosePanel_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006757 RID: 26455
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006758 RID: 26456
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006759 RID: 26457
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400675A RID: 26458
			private static readonly IntPtr NativeFieldInfoPtr_closeContext;

			// Token: 0x0400675B RID: 26459
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400675C RID: 26460
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400675D RID: 26461
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
