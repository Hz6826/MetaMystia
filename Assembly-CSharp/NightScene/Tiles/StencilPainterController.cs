using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene.Tiles
{
	// Token: 0x020001AE RID: 430
	public class StencilPainterController : MonoBehaviour
	{
		// Token: 0x0600340F RID: 13327 RVA: 0x001515F0 File Offset: 0x0014F7F0
		// Note: this type is marked as 'beforefieldinit'.
		static StencilPainterController()
		{
			Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.Tiles", "StencilPainterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr);
			StencilPainterController.NativeFieldInfoPtr_worker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, "worker");
			StencilPainterController.NativeFieldInfoPtr_onRefreshingStencilPainter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, "onRefreshingStencilPainter");
			StencilPainterController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, 100673254);
			StencilPainterController.NativeMethodInfoPtr_Show_Public_Void_Vector3_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, 100673255);
			StencilPainterController.NativeMethodInfoPtr_Hide_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, 100673256);
			StencilPainterController.NativeMethodInfoPtr_OnShowingStencilPainter_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, 100673257);
			StencilPainterController.NativeMethodInfoPtr_OnHidingStencilPainter_Private_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, 100673258);
			StencilPainterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, 100673259);
			StencilPainterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, 100673260);
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x001516D4 File Offset: 0x0014F8D4
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00151708 File Offset: 0x0014F908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123933, XrefRangeEnd = 123958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(Vector3 coordinate, Sprite visual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref coordinate;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.NativeMethodInfoPtr_Show_Public_Void_Vector3_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00151758 File Offset: 0x0014F958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123958, XrefRangeEnd = 123968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide(Action onHideFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onHideFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.NativeMethodInfoPtr_Hide_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x0015179C File Offset: 0x0014F99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123968, XrefRangeEnd = 123973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnShowingStencilPainter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.NativeMethodInfoPtr_OnShowingStencilPainter_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x001517DC File Offset: 0x0014F9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123973, XrefRangeEnd = 123979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnHidingStencilPainter(Action onHideFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onHideFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.NativeMethodInfoPtr_OnHidingStencilPainter_Private_IEnumerator_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x0015182C File Offset: 0x0014FA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StencilPainterController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x00151868 File Offset: 0x0014FA68
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StencilPainterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x0001CF53 File Offset: 0x0001B153
		public StencilPainterController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x001518A4 File Offset: 0x0014FAA4
		// (set) Token: 0x06003419 RID: 13337 RVA: 0x0001CF5C File Offset: 0x0001B15C
		public unsafe List<SpriteRenderer> worker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController.NativeFieldInfoPtr_worker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController.NativeFieldInfoPtr_worker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600341A RID: 13338 RVA: 0x001518D4 File Offset: 0x0014FAD4
		// (set) Token: 0x0600341B RID: 13339 RVA: 0x0001CF7B File Offset: 0x0001B17B
		public unsafe Coroutine onRefreshingStencilPainter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController.NativeFieldInfoPtr_onRefreshingStencilPainter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController.NativeFieldInfoPtr_onRefreshingStencilPainter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeFieldInfoPtr_worker;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeFieldInfoPtr_onRefreshingStencilPainter;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_Vector3_Sprite_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_Action_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_OnShowingStencilPainter_Private_IEnumerator_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_OnHidingStencilPainter_Private_IEnumerator_Action_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008F7 RID: 2295
		[ObfuscatedName("NightScene.Tiles.StencilPainterController+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B62E RID: 46638 RVA: 0x002E41F0 File Offset: 0x002E23F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<StencilPainterController.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilPainterController.__c__DisplayClass3_0>.NativeClassPtr);
				StencilPainterController.__c__DisplayClass3_0.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController.__c__DisplayClass3_0>.NativeClassPtr, "visual");
				StencilPainterController.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController.__c__DisplayClass3_0>.NativeClassPtr, 100673261);
				StencilPainterController.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController.__c__DisplayClass3_0>.NativeClassPtr, 100673262);
			}

			// Token: 0x0600B62F RID: 46639 RVA: 0x002E4258 File Offset: 0x002E2458
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilPainterController.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B630 RID: 46640 RVA: 0x002E4294 File Offset: 0x002E2494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123814, XrefRangeEnd = 123816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpriteRenderer_0(SpriteRenderer spriteRenderer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteRenderer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.__c__DisplayClass3_0.NativeMethodInfoPtr_Method_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B631 RID: 46641 RVA: 0x0006235D File Offset: 0x0006055D
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BC3 RID: 15299
			// (get) Token: 0x0600B632 RID: 46642 RVA: 0x002E42D8 File Offset: 0x002E24D8
			// (set) Token: 0x0600B633 RID: 46643 RVA: 0x00062366 File Offset: 0x00060566
			public unsafe Sprite visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController.__c__DisplayClass3_0.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController.__c__DisplayClass3_0.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040075E3 RID: 30179
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x040075E4 RID: 30180
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040075E5 RID: 30181
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpriteRenderer_0;
		}

		// Token: 0x020008F8 RID: 2296
		[ObfuscatedName("NightScene.Tiles.StencilPainterController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B634 RID: 46644 RVA: 0x002E4308 File Offset: 0x002E2508
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr);
				StencilPainterController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr, "<>9");
				StencilPainterController.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr, "<>9__5_0");
				StencilPainterController.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr, "<>9__6_0");
				StencilPainterController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr, 100673264);
				StencilPainterController.__c.NativeMethodInfoPtr__OnShowingStencilPainter_b__5_0_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr, 100673265);
				StencilPainterController.__c.NativeMethodInfoPtr__OnHidingStencilPainter_b__6_0_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr, 100673266);
			}

			// Token: 0x0600B635 RID: 46645 RVA: 0x002E43AC File Offset: 0x002E25AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilPainterController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B636 RID: 46646 RVA: 0x002E43E8 File Offset: 0x002E25E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123816, XrefRangeEnd = 123818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShowingStencilPainter_b__5_0(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.__c.NativeMethodInfoPtr__OnShowingStencilPainter_b__5_0_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B637 RID: 46647 RVA: 0x002E442C File Offset: 0x002E262C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123818, XrefRangeEnd = 123820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnHidingStencilPainter_b__6_0(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController.__c.NativeMethodInfoPtr__OnHidingStencilPainter_b__6_0_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B638 RID: 46648 RVA: 0x00062385 File Offset: 0x00060585
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BC4 RID: 15300
			// (get) Token: 0x0600B639 RID: 46649 RVA: 0x002E4470 File Offset: 0x002E2670
			// (set) Token: 0x0600B63A RID: 46650 RVA: 0x0006238E File Offset: 0x0006058E
			public unsafe static StencilPainterController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StencilPainterController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StencilPainterController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StencilPainterController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BC5 RID: 15301
			// (get) Token: 0x0600B63B RID: 46651 RVA: 0x002E4498 File Offset: 0x002E2698
			// (set) Token: 0x0600B63C RID: 46652 RVA: 0x000623A0 File Offset: 0x000605A0
			public unsafe static Action<SpriteRenderer> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StencilPainterController.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StencilPainterController.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BC6 RID: 15302
			// (get) Token: 0x0600B63D RID: 46653 RVA: 0x002E44C0 File Offset: 0x002E26C0
			// (set) Token: 0x0600B63E RID: 46654 RVA: 0x000623B2 File Offset: 0x000605B2
			public unsafe static Action<SpriteRenderer> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StencilPainterController.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StencilPainterController.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040075E6 RID: 30182
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040075E7 RID: 30183
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040075E8 RID: 30184
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040075E9 RID: 30185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040075EA RID: 30186
			private static readonly IntPtr NativeMethodInfoPtr__OnShowingStencilPainter_b__5_0_Internal_Void_SpriteRenderer_0;

			// Token: 0x040075EB RID: 30187
			private static readonly IntPtr NativeMethodInfoPtr__OnHidingStencilPainter_b__6_0_Internal_Void_SpriteRenderer_0;
		}

		// Token: 0x020008F9 RID: 2297
		[ObfuscatedName("NightScene.Tiles.StencilPainterController+<OnShowingStencilPainter>d__5")]
		public sealed class _OnShowingStencilPainter_d__5 : Il2CppSystem.Object
		{
			// Token: 0x0600B63F RID: 46655 RVA: 0x002E44E8 File Offset: 0x002E26E8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnShowingStencilPainter_d__5()
			{
				Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, "<OnShowingStencilPainter>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr);
				StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, "<>1__state");
				StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, "<>2__current");
				StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, "<>4__this");
				StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, "<>7__wrap1");
				StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, 100673267);
				StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, 100673268);
				StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, 100673269);
				StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, 100673270);
				StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, 100673271);
				StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, 100673272);
				StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr, 100673273);
			}

			// Token: 0x0600B640 RID: 46656 RVA: 0x002E45F0 File Offset: 0x002E27F0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnShowingStencilPainter_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilPainterController._OnShowingStencilPainter_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B641 RID: 46657 RVA: 0x002E4638 File Offset: 0x002E2838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123820, XrefRangeEnd = 123825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B642 RID: 46658 RVA: 0x002E466C File Offset: 0x002E286C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123825, XrefRangeEnd = 123865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B643 RID: 46659 RVA: 0x002E46A8 File Offset: 0x002E28A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123865, XrefRangeEnd = 123868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BCB RID: 15307
			// (get) Token: 0x0600B644 RID: 46660 RVA: 0x002E46DC File Offset: 0x002E28DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B645 RID: 46661 RVA: 0x002E471C File Offset: 0x002E291C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123868, XrefRangeEnd = 123874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BCC RID: 15308
			// (get) Token: 0x0600B646 RID: 46662 RVA: 0x002E4750 File Offset: 0x002E2950
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnShowingStencilPainter_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B647 RID: 46663 RVA: 0x000623C4 File Offset: 0x000605C4
			public _OnShowingStencilPainter_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BC7 RID: 15303
			// (get) Token: 0x0600B648 RID: 46664 RVA: 0x002E4790 File Offset: 0x002E2990
			// (set) Token: 0x0600B649 RID: 46665 RVA: 0x000623CD File Offset: 0x000605CD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003BC8 RID: 15304
			// (get) Token: 0x0600B64A RID: 46666 RVA: 0x002E47B8 File Offset: 0x002E29B8
			// (set) Token: 0x0600B64B RID: 46667 RVA: 0x000623E8 File Offset: 0x000605E8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BC9 RID: 15305
			// (get) Token: 0x0600B64C RID: 46668 RVA: 0x002E47E8 File Offset: 0x002E29E8
			// (set) Token: 0x0600B64D RID: 46669 RVA: 0x00062407 File Offset: 0x00060607
			public unsafe StencilPainterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StencilPainterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BCA RID: 15306
			// (get) Token: 0x0600B64E RID: 46670 RVA: 0x002E4818 File Offset: 0x002E2A18
			// (set) Token: 0x0600B64F RID: 46671 RVA: 0x00062426 File Offset: 0x00060626
			public List<SpriteRenderer>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___7__wrap1);
					return new List<SpriteRenderer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<SpriteRenderer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnShowingStencilPainter_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<SpriteRenderer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040075EC RID: 30188
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040075ED RID: 30189
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040075EE RID: 30190
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040075EF RID: 30191
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040075F0 RID: 30192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040075F1 RID: 30193
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040075F2 RID: 30194
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040075F3 RID: 30195
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040075F4 RID: 30196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040075F5 RID: 30197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040075F6 RID: 30198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008FA RID: 2298
		[ObfuscatedName("NightScene.Tiles.StencilPainterController+<OnHidingStencilPainter>d__6")]
		public sealed class _OnHidingStencilPainter_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600B650 RID: 46672 RVA: 0x002E4848 File Offset: 0x002E2A48
			// Note: this type is marked as 'beforefieldinit'.
			static _OnHidingStencilPainter_d__6()
			{
				Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StencilPainterController>.NativeClassPtr, "<OnHidingStencilPainter>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr);
				StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, "<>1__state");
				StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, "<>2__current");
				StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, "<>4__this");
				StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr_onHideFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, "onHideFinish");
				StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, "<>7__wrap1");
				StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, 100673274);
				StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, 100673275);
				StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, 100673276);
				StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, 100673277);
				StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, 100673278);
				StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, 100673279);
				StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr, 100673280);
			}

			// Token: 0x0600B651 RID: 46673 RVA: 0x002E4964 File Offset: 0x002E2B64
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnHidingStencilPainter_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilPainterController._OnHidingStencilPainter_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B652 RID: 46674 RVA: 0x002E49AC File Offset: 0x002E2BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123874, XrefRangeEnd = 123879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B653 RID: 46675 RVA: 0x002E49E0 File Offset: 0x002E2BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123879, XrefRangeEnd = 123924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B654 RID: 46676 RVA: 0x002E4A1C File Offset: 0x002E2C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123924, XrefRangeEnd = 123927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BD2 RID: 15314
			// (get) Token: 0x0600B655 RID: 46677 RVA: 0x002E4A50 File Offset: 0x002E2C50
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B656 RID: 46678 RVA: 0x002E4A90 File Offset: 0x002E2C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123927, XrefRangeEnd = 123933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BD3 RID: 15315
			// (get) Token: 0x0600B657 RID: 46679 RVA: 0x002E4AC4 File Offset: 0x002E2CC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilPainterController._OnHidingStencilPainter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B658 RID: 46680 RVA: 0x00062454 File Offset: 0x00060654
			public _OnHidingStencilPainter_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BCD RID: 15309
			// (get) Token: 0x0600B659 RID: 46681 RVA: 0x002E4B04 File Offset: 0x002E2D04
			// (set) Token: 0x0600B65A RID: 46682 RVA: 0x0006245D File Offset: 0x0006065D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003BCE RID: 15310
			// (get) Token: 0x0600B65B RID: 46683 RVA: 0x002E4B2C File Offset: 0x002E2D2C
			// (set) Token: 0x0600B65C RID: 46684 RVA: 0x00062478 File Offset: 0x00060678
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BCF RID: 15311
			// (get) Token: 0x0600B65D RID: 46685 RVA: 0x002E4B5C File Offset: 0x002E2D5C
			// (set) Token: 0x0600B65E RID: 46686 RVA: 0x00062497 File Offset: 0x00060697
			public unsafe StencilPainterController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StencilPainterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BD0 RID: 15312
			// (get) Token: 0x0600B65F RID: 46687 RVA: 0x002E4B8C File Offset: 0x002E2D8C
			// (set) Token: 0x0600B660 RID: 46688 RVA: 0x000624B6 File Offset: 0x000606B6
			public unsafe Action onHideFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr_onHideFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr_onHideFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BD1 RID: 15313
			// (get) Token: 0x0600B661 RID: 46689 RVA: 0x002E4BBC File Offset: 0x002E2DBC
			// (set) Token: 0x0600B662 RID: 46690 RVA: 0x000624D5 File Offset: 0x000606D5
			public List<SpriteRenderer>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___7__wrap1);
					return new List<SpriteRenderer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<SpriteRenderer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StencilPainterController._OnHidingStencilPainter_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<SpriteRenderer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040075F7 RID: 30199
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040075F8 RID: 30200
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040075F9 RID: 30201
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040075FA RID: 30202
			private static readonly IntPtr NativeFieldInfoPtr_onHideFinish;

			// Token: 0x040075FB RID: 30203
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040075FC RID: 30204
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040075FD RID: 30205
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040075FE RID: 30206
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040075FF RID: 30207
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007600 RID: 30208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007601 RID: 30209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007602 RID: 30210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
