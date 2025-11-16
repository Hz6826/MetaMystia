using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.UI;

namespace Common.UI.Story
{
	// Token: 0x020003C3 RID: 963
	public class EventMainMenuPannel : UIPanel
	{
		// Token: 0x060072F0 RID: 29424 RVA: 0x0021DCD0 File Offset: 0x0021BED0
		// Note: this type is marked as 'beforefieldinit'.
		static EventMainMenuPannel()
		{
			Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Story", "EventMainMenuPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr);
			EventMainMenuPannel.NativeFieldInfoPtr_ContinueGameBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, "ContinueGameBtn");
			EventMainMenuPannel.NativeFieldInfoPtr_TitleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, "TitleSprite");
			EventMainMenuPannel.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, "Title");
			EventMainMenuPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686958);
			EventMainMenuPannel.NativeMethodInfoPtr_ContinueGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686959);
			EventMainMenuPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686960);
			EventMainMenuPannel.NativeMethodInfoPtr_ExecuteDelayed_Private_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686961);
			EventMainMenuPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686962);
			EventMainMenuPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686963);
			EventMainMenuPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686964);
			EventMainMenuPannel.NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686965);
			EventMainMenuPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, 100686966);
		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x0021DDF0 File Offset: 0x0021BFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287150, XrefRangeEnd = 287162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventMainMenuPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x0021DE2C File Offset: 0x0021C02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287162, XrefRangeEnd = 287173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel.NativeMethodInfoPtr_ContinueGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x0021DE60 File Offset: 0x0021C060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287173, XrefRangeEnd = 287183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventMainMenuPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x0021DE9C File Offset: 0x0021C09C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287188, RefRangeEnd = 287190, XrefRangeStart = 287183, XrefRangeEnd = 287188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteDelayed(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel.NativeMethodInfoPtr_ExecuteDelayed_Private_IEnumerator_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x0021DEEC File Offset: 0x0021C0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287190, XrefRangeEnd = 287193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventMainMenuPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x0021DF28 File Offset: 0x0021C128
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventMainMenuPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x0021DF64 File Offset: 0x0021C164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287193, XrefRangeEnd = 287215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x0021DF98 File Offset: 0x0021C198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287215, XrefRangeEnd = 287226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel.NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x0021DFCC File Offset: 0x0021C1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287226, XrefRangeEnd = 287228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x0003E298 File Offset: 0x0003C498
		public EventMainMenuPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x060072FB RID: 29435 RVA: 0x0021E000 File Offset: 0x0021C200
		// (set) Token: 0x060072FC RID: 29436 RVA: 0x0003E2A1 File Offset: 0x0003C4A1
		public unsafe UIButtonSimple ContinueGameBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel.NativeFieldInfoPtr_ContinueGameBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel.NativeFieldInfoPtr_ContinueGameBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x060072FD RID: 29437 RVA: 0x0021E030 File Offset: 0x0021C230
		// (set) Token: 0x060072FE RID: 29438 RVA: 0x0003E2C0 File Offset: 0x0003C4C0
		public MultiLanguageSprite TitleSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel.NativeFieldInfoPtr_TitleSprite);
				return new MultiLanguageSprite(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel.NativeFieldInfoPtr_TitleSprite), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x060072FF RID: 29439 RVA: 0x0021E060 File Offset: 0x0021C260
		// (set) Token: 0x06007300 RID: 29440 RVA: 0x0003E2EE File Offset: 0x0003C4EE
		public unsafe Image Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C31 RID: 19505
		private static readonly IntPtr NativeFieldInfoPtr_ContinueGameBtn;

		// Token: 0x04004C32 RID: 19506
		private static readonly IntPtr NativeFieldInfoPtr_TitleSprite;

		// Token: 0x04004C33 RID: 19507
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04004C34 RID: 19508
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004C35 RID: 19509
		private static readonly IntPtr NativeMethodInfoPtr_ContinueGame_Private_Void_0;

		// Token: 0x04004C36 RID: 19510
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004C37 RID: 19511
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDelayed_Private_IEnumerator_Action_0;

		// Token: 0x04004C38 RID: 19512
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C39 RID: 19513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004C3A RID: 19514
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x04004C3B RID: 19515
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_0_Private_Void_0;

		// Token: 0x04004C3C RID: 19516
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_1;

		// Token: 0x02000F46 RID: 3910
		[ObfuscatedName("Common.UI.Story.EventMainMenuPannel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060110A0 RID: 69792 RVA: 0x003EF3BC File Offset: 0x003ED5BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EventMainMenuPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventMainMenuPannel.__c>.NativeClassPtr);
				EventMainMenuPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMainMenuPannel.__c>.NativeClassPtr, "<>9");
				EventMainMenuPannel.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMainMenuPannel.__c>.NativeClassPtr, "<>9__4_1");
				EventMainMenuPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel.__c>.NativeClassPtr, 100686968);
				EventMainMenuPannel.__c.NativeMethodInfoPtr__ContinueGame_b__4_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel.__c>.NativeClassPtr, 100686969);
			}

			// Token: 0x060110A1 RID: 69793 RVA: 0x003EF438 File Offset: 0x003ED638
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMainMenuPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110A2 RID: 69794 RVA: 0x003EF474 File Offset: 0x003ED674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287135, XrefRangeEnd = 287139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ContinueGame_b__4_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel.__c.NativeMethodInfoPtr__ContinueGame_b__4_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110A3 RID: 69795 RVA: 0x000942F5 File Offset: 0x000924F5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058A2 RID: 22690
			// (get) Token: 0x060110A4 RID: 69796 RVA: 0x003EF4A8 File Offset: 0x003ED6A8
			// (set) Token: 0x060110A5 RID: 69797 RVA: 0x000942FE File Offset: 0x000924FE
			public unsafe static EventMainMenuPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EventMainMenuPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventMainMenuPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EventMainMenuPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058A3 RID: 22691
			// (get) Token: 0x060110A6 RID: 69798 RVA: 0x003EF4D0 File Offset: 0x003ED6D0
			// (set) Token: 0x060110A7 RID: 69799 RVA: 0x00094310 File Offset: 0x00092510
			public unsafe static Action __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EventMainMenuPannel.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EventMainMenuPannel.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC5D RID: 44125
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AC5E RID: 44126
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400AC5F RID: 44127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC60 RID: 44128
			private static readonly IntPtr NativeMethodInfoPtr__ContinueGame_b__4_1_Internal_Void_0;
		}

		// Token: 0x02000F47 RID: 3911
		[ObfuscatedName("Common.UI.Story.EventMainMenuPannel+<ExecuteDelayed>d__6")]
		public sealed class _ExecuteDelayed_d__6 : Object
		{
			// Token: 0x060110A8 RID: 69800 RVA: 0x003EF4F8 File Offset: 0x003ED6F8
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteDelayed_d__6()
			{
				Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventMainMenuPannel>.NativeClassPtr, "<ExecuteDelayed>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr);
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, "<>1__state");
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, "<>2__current");
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, "action");
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, 100686970);
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, 100686971);
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, 100686972);
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, 100686973);
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, 100686974);
				EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr, 100686975);
			}

			// Token: 0x060110A9 RID: 69801 RVA: 0x003EF5D8 File Offset: 0x003ED7D8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteDelayed_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventMainMenuPannel._ExecuteDelayed_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110AA RID: 69802 RVA: 0x003EF620 File Offset: 0x003ED820
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110AB RID: 69803 RVA: 0x003EF654 File Offset: 0x003ED854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287139, XrefRangeEnd = 287144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170058A7 RID: 22695
			// (get) Token: 0x060110AC RID: 69804 RVA: 0x003EF690 File Offset: 0x003ED890
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060110AD RID: 69805 RVA: 0x003EF6D0 File Offset: 0x003ED8D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287144, XrefRangeEnd = 287150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170058A8 RID: 22696
			// (get) Token: 0x060110AE RID: 69806 RVA: 0x003EF704 File Offset: 0x003ED904
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventMainMenuPannel._ExecuteDelayed_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060110AF RID: 69807 RVA: 0x00094322 File Offset: 0x00092522
			public _ExecuteDelayed_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058A4 RID: 22692
			// (get) Token: 0x060110B0 RID: 69808 RVA: 0x003EF744 File Offset: 0x003ED944
			// (set) Token: 0x060110B1 RID: 69809 RVA: 0x0009432B File Offset: 0x0009252B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170058A5 RID: 22693
			// (get) Token: 0x060110B2 RID: 69810 RVA: 0x003EF76C File Offset: 0x003ED96C
			// (set) Token: 0x060110B3 RID: 69811 RVA: 0x00094346 File Offset: 0x00092546
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170058A6 RID: 22694
			// (get) Token: 0x060110B4 RID: 69812 RVA: 0x003EF79C File Offset: 0x003ED99C
			// (set) Token: 0x060110B5 RID: 69813 RVA: 0x00094365 File Offset: 0x00092565
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventMainMenuPannel._ExecuteDelayed_d__6.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC61 RID: 44129
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AC62 RID: 44130
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AC63 RID: 44131
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x0400AC64 RID: 44132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AC65 RID: 44133
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC66 RID: 44134
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AC67 RID: 44135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AC68 RID: 44136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AC69 RID: 44137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
