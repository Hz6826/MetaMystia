using System;
using Common.UI.QTEUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.Story
{
	// Token: 0x020003C4 RID: 964
	public class EventQTETutorialNotePannel : EventQTETutorialSubPannel
	{
		// Token: 0x06007301 RID: 29441 RVA: 0x0021E090 File Offset: 0x0021C290
		// Note: this type is marked as 'beforefieldinit'.
		static EventQTETutorialNotePannel()
		{
			Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Story", "EventQTETutorialNotePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr);
			EventQTETutorialNotePannel.NativeFieldInfoPtr_m_InputHelperField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "m_InputHelperField");
			EventQTETutorialNotePannel.NativeFieldInfoPtr_m_InputHighlightVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "m_InputHighlightVisual");
			EventQTETutorialNotePannel.NativeFieldInfoPtr_m_PerfectSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "m_PerfectSFX");
			EventQTETutorialNotePannel.NativeFieldInfoPtr_m_SingleNoteVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "m_SingleNoteVisual");
			EventQTETutorialNotePannel.NativeFieldInfoPtr_m_CatchNoteVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "m_CatchNoteVisual");
			EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteSucceedAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "m_NoteSucceedAnimation");
			EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteAnimationField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "m_NoteAnimationField");
			EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteAnimationReferencePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "m_NoteAnimationReferencePosition");
			EventQTETutorialNotePannel.NativeMethodInfoPtr_PlaySFX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, 100686976);
			EventQTETutorialNotePannel.NativeMethodInfoPtr_ToggleBtnVisual_Public_Void_ToggleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, 100686977);
			EventQTETutorialNotePannel.NativeMethodInfoPtr_PlaySingleNoteSucceedAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, 100686978);
			EventQTETutorialNotePannel.NativeMethodInfoPtr_PlayCatchNoteSucceedAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, 100686979);
			EventQTETutorialNotePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, 100686980);
			EventQTETutorialNotePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, 100686981);
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x0021E1D8 File Offset: 0x0021C3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287228, XrefRangeEnd = 287233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaySFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialNotePannel.NativeMethodInfoPtr_PlaySFX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x0021E20C File Offset: 0x0021C40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287233, XrefRangeEnd = 287255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleBtnVisual(EventQTETutorialNotePannel.ToggleType on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialNotePannel.NativeMethodInfoPtr_ToggleBtnVisual_Public_Void_ToggleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x0021E24C File Offset: 0x0021C44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287255, XrefRangeEnd = 287264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaySingleNoteSucceedAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialNotePannel.NativeMethodInfoPtr_PlaySingleNoteSucceedAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x0021E280 File Offset: 0x0021C480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287264, XrefRangeEnd = 287273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCatchNoteSucceedAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialNotePannel.NativeMethodInfoPtr_PlayCatchNoteSucceedAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x0021E2B4 File Offset: 0x0021C4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventQTETutorialNotePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x0021E2F0 File Offset: 0x0021C4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287273, XrefRangeEnd = 287276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventQTETutorialNotePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialNotePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x0003E30D File Offset: 0x0003C50D
		public EventQTETutorialNotePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x06007309 RID: 29449 RVA: 0x0021E32C File Offset: 0x0021C52C
		// (set) Token: 0x0600730A RID: 29450 RVA: 0x0003E316 File Offset: 0x0003C516
		public unsafe GameObject m_InputHelperField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_InputHelperField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_InputHelperField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x0600730B RID: 29451 RVA: 0x0021E35C File Offset: 0x0021C55C
		// (set) Token: 0x0600730C RID: 29452 RVA: 0x0003E335 File Offset: 0x0003C535
		public unsafe Sprite m_InputHighlightVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_InputHighlightVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_InputHighlightVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x0600730D RID: 29453 RVA: 0x0021E38C File Offset: 0x0021C58C
		// (set) Token: 0x0600730E RID: 29454 RVA: 0x0003E354 File Offset: 0x0003C554
		public unsafe AudioClip m_PerfectSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_PerfectSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_PerfectSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x0600730F RID: 29455 RVA: 0x0021E3BC File Offset: 0x0021C5BC
		// (set) Token: 0x06007310 RID: 29456 RVA: 0x0003E373 File Offset: 0x0003C573
		public unsafe Sprite m_SingleNoteVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_SingleNoteVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_SingleNoteVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x06007311 RID: 29457 RVA: 0x0021E3EC File Offset: 0x0021C5EC
		// (set) Token: 0x06007312 RID: 29458 RVA: 0x0003E392 File Offset: 0x0003C592
		public unsafe Sprite m_CatchNoteVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_CatchNoteVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_CatchNoteVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x0021E41C File Offset: 0x0021C61C
		// (set) Token: 0x06007314 RID: 29460 RVA: 0x0003E3B1 File Offset: 0x0003C5B1
		public unsafe NoteHeadFinishAnimationController m_NoteSucceedAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteSucceedAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteSucceedAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x0021E44C File Offset: 0x0021C64C
		// (set) Token: 0x06007316 RID: 29462 RVA: 0x0003E3D0 File Offset: 0x0003C5D0
		public unsafe RectTransform m_NoteAnimationField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteAnimationField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteAnimationField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x06007317 RID: 29463 RVA: 0x0021E47C File Offset: 0x0021C67C
		// (set) Token: 0x06007318 RID: 29464 RVA: 0x0003E3EF File Offset: 0x0003C5EF
		public unsafe RectTransform m_NoteAnimationReferencePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteAnimationReferencePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.NativeFieldInfoPtr_m_NoteAnimationReferencePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C3D RID: 19517
		private static readonly IntPtr NativeFieldInfoPtr_m_InputHelperField;

		// Token: 0x04004C3E RID: 19518
		private static readonly IntPtr NativeFieldInfoPtr_m_InputHighlightVisual;

		// Token: 0x04004C3F RID: 19519
		private static readonly IntPtr NativeFieldInfoPtr_m_PerfectSFX;

		// Token: 0x04004C40 RID: 19520
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleNoteVisual;

		// Token: 0x04004C41 RID: 19521
		private static readonly IntPtr NativeFieldInfoPtr_m_CatchNoteVisual;

		// Token: 0x04004C42 RID: 19522
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteSucceedAnimation;

		// Token: 0x04004C43 RID: 19523
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteAnimationField;

		// Token: 0x04004C44 RID: 19524
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteAnimationReferencePosition;

		// Token: 0x04004C45 RID: 19525
		private static readonly IntPtr NativeMethodInfoPtr_PlaySFX_Public_Void_0;

		// Token: 0x04004C46 RID: 19526
		private static readonly IntPtr NativeMethodInfoPtr_ToggleBtnVisual_Public_Void_ToggleType_0;

		// Token: 0x04004C47 RID: 19527
		private static readonly IntPtr NativeMethodInfoPtr_PlaySingleNoteSucceedAnimation_Public_Void_0;

		// Token: 0x04004C48 RID: 19528
		private static readonly IntPtr NativeMethodInfoPtr_PlayCatchNoteSucceedAnimation_Public_Void_0;

		// Token: 0x04004C49 RID: 19529
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004C4A RID: 19530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F48 RID: 3912
		public enum ToggleType
		{
			// Token: 0x0400AC6B RID: 44139
			ON,
			// Token: 0x0400AC6C RID: 44140
			OFF
		}

		// Token: 0x02000F49 RID: 3913
		[ObfuscatedName("Common.UI.Story.EventQTETutorialNotePannel+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x060110B6 RID: 69814 RVA: 0x003EF7CC File Offset: 0x003ED9CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<EventQTETutorialNotePannel.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventQTETutorialNotePannel>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventQTETutorialNotePannel.__c__DisplayClass10_0>.NativeClassPtr);
				EventQTETutorialNotePannel.__c__DisplayClass10_0.NativeFieldInfoPtr_spriteToSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventQTETutorialNotePannel.__c__DisplayClass10_0>.NativeClassPtr, "spriteToSet");
				EventQTETutorialNotePannel.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialNotePannel.__c__DisplayClass10_0>.NativeClassPtr, 100686982);
				EventQTETutorialNotePannel.__c__DisplayClass10_0.NativeMethodInfoPtr__ToggleBtnVisual_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventQTETutorialNotePannel.__c__DisplayClass10_0>.NativeClassPtr, 100686983);
			}

			// Token: 0x060110B7 RID: 69815 RVA: 0x003EF834 File Offset: 0x003EDA34
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventQTETutorialNotePannel.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialNotePannel.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110B8 RID: 69816 RVA: 0x003EF870 File Offset: 0x003EDA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ToggleBtnVisual_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventQTETutorialNotePannel.__c__DisplayClass10_0.NativeMethodInfoPtr__ToggleBtnVisual_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060110B9 RID: 69817 RVA: 0x00094384 File Offset: 0x00092584
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170058A9 RID: 22697
			// (get) Token: 0x060110BA RID: 69818 RVA: 0x003EF8B4 File Offset: 0x003EDAB4
			// (set) Token: 0x060110BB RID: 69819 RVA: 0x0009438D File Offset: 0x0009258D
			public unsafe Sprite spriteToSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.__c__DisplayClass10_0.NativeFieldInfoPtr_spriteToSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventQTETutorialNotePannel.__c__DisplayClass10_0.NativeFieldInfoPtr_spriteToSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AC6D RID: 44141
			private static readonly IntPtr NativeFieldInfoPtr_spriteToSet;

			// Token: 0x0400AC6E RID: 44142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AC6F RID: 44143
			private static readonly IntPtr NativeMethodInfoPtr__ToggleBtnVisual_b__0_Internal_Void_Image_0;
		}
	}
}
